using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_Planificador_FCFS
{
    public partial class Formulario_Ejecuccion : Form
    {
        private Queue<Proceso> Cola_procesos_nuevos; //Cola de procesos nuevos
        private Queue<Proceso> Cola_procesos_listos; //La cola de procesos listos
        private List<Proceso> Cola_procesos_bloqueados; //La cola de procesos ejecutados

        private Proceso procesoE; // Proceso en ejecución
        private Stopwatch stopwatchGlobal = new Stopwatch();
        private Stopwatch stopwatchProceso = new Stopwatch();
        private System.Windows.Forms.Timer timerActualizacion;
        private CancellationTokenSource cts;
        private bool pausaActiva = false;
        private bool interrupcionActiva = false;
        private bool errorActiva = false;

        int contador_debug = 0;

        public Formulario_Ejecuccion()
        {
            InitializeComponent();
            timerActualizacion = new System.Windows.Forms.Timer();
            timerActualizacion.Interval = 10; // 10 milisegundos
            timerActualizacion.Tick += TimerActualizacion_Tick;
        }

        public void Inicializar()
        {
            cajaNProcListos.Text = $"{Cola_procesos_nuevos.Count}";
            Cola_procesos_listos = new Queue<Proceso>();
            Cola_procesos_bloqueados = new List<Proceso>();
            cajaTiempoGlobal.Text = "0.00";
            cajaTiempoProceso.Text = "0.00";
            timerActualizacion.Start();
        }

        public void InicializarCola(Queue<Proceso> Temp_cola)
        {
            Cola_procesos_nuevos = Temp_cola;
            Inicializar();
        }

        public void LlenarTablaListos()
        {
            TablaProcesosListos.Rows.Clear();
            foreach (Proceso Ptemp in Cola_procesos_listos)
            {
                TablaProcesosListos.Rows.Add(
                    Ptemp.NumeroPrograma.ToString(),
                    ((float)Ptemp.TiempoMaximoEstimado / 1000).ToString("F2"),
                    ((float)Ptemp.TiempoTrabajado / 1000).ToString("F2")
                );
            }
        }

        public void VaciarTablaProcesoEjecutando()
        {
            procesoE = null;
            TablaProcesosEjecutando.Rows.Clear();
            TablaProcesosEjecutando.Rows.Add("N° ID", "");
            TablaProcesosEjecutando.Rows.Add("Operación", "");
            TablaProcesosEjecutando.Rows.Add("Tiempo Máximo estimado (Segundos)", "");
            cajaTiempoProceso.Text = "0.00";
        }

        private async Task IniciarSigP(CancellationToken token)
        {
            if (token.IsCancellationRequested) return;
            Debug.WriteLine($"Entro {contador_debug++}");

            cajaNProcListos.Text = Cola_procesos_nuevos.Count.ToString();
            LlenarTablaListos();
            await EjecutarProcesoActual(token);
        }

        private async Task EjecutarProcesoActual(CancellationToken token)
        {
            if (token.IsCancellationRequested) return;

            procesoE = Cola_procesos_listos.Dequeue();

            if (procesoE.TiempoRespuesta < 0) { procesoE.TiempoRespuesta = (stopwatchGlobal.Elapsed.TotalMilliseconds - procesoE.TiempoLlegada); }

            LlenarTablaListos();
            TablaProcesosEjecutando.Rows.Clear();
            TablaProcesosEjecutando.Rows.Add("N° ID", procesoE.NumeroPrograma.ToString());
            TablaProcesosEjecutando.Rows.Add("Operación", procesoE.getExpresion());
            TablaProcesosEjecutando.Rows.Add("Tiempo Máximo estimado (Segundos)", $"{procesoE.TiempoMaximoEstimado / 1000}");

            double tiempoRestante = procesoE.TiempoMaximoEstimado - procesoE.TiempoTrabajado;

            stopwatchProceso.Restart(); // Inicia el temporizador del proceso en 0

            while (stopwatchProceso.ElapsedMilliseconds <= tiempoRestante)
            {
                // Mientras la pausa esté activa, espera
                while (pausaActiva)
                {
                    await Task.Delay(10); // Espera 10ms antes de volver a verificar
                }
                if (interrupcionActiva)
                {
                    stopwatchProceso.Stop();
                    interrupcionActiva = false;
                    procesoE.TiempoTrabajado = stopwatchProceso.ElapsedMilliseconds + procesoE.TiempoTrabajado;
                    procesoE.TiempoBloqueado = 0;
                    Cola_procesos_bloqueados.Add(procesoE);
                    VaciarTablaProcesoEjecutando(); //Libera el proceso en ejecución
                    return; // Sal del bucle y regresa al flujo principal
                }
                if (errorActiva)
                {
                    stopwatchProceso.Stop();
                    procesoE.TiempoFinalizado = stopwatchGlobal.ElapsedMilliseconds;
                    procesoE.calcularRetorno();
                    procesoE.TiempoTrabajado = stopwatchProceso.ElapsedMilliseconds + procesoE.TiempoTrabajado;
                    errorActiva = false;
                    // Agregar a la tabla de procesos completados
                    tablaProcesosCompletados.Rows.Add(
                        procesoE.NumeroPrograma.ToString(),
                        procesoE.getExpresion(),
                        "Error por Interrupción",
                        (procesoE.TiempoMaximoEstimado / 1000).ToString("F2"),
                        (procesoE.TiempoLlegada / 1000).ToString("F2"),
                        (procesoE.TiempoFinalizado / 1000).ToString("F2"),
                        (procesoE.TiempoEspera / 1000).ToString("F2"),
                        (procesoE.TiempoTrabajado / 1000).ToString("F2"),
                        (procesoE.TiempoRetorno / 1000).ToString("F2"),
                        (procesoE.TiempoRespuesta / 1000).ToString("F2")
                    );
                    cajaTiempoProceso.Text = "0.00";
                    stopwatchProceso.Reset();
                    VaciarTablaProcesoEjecutando();
                    return;
                }
                if (cts.Token.IsCancellationRequested)
                {
                    return; // Termina si se solicita la cancelación
                }
                await Task.Delay(10); // Pausa pequeña para evitar que el bucle consuma demasiado CPU
            }
            stopwatchProceso.Stop(); // Detenemos el cronómetro cuando se completa el proceso
            procesoE.TiempoFinalizado = stopwatchGlobal.ElapsedMilliseconds;
            procesoE.calcularRetorno();
            procesoE.TiempoTrabajado = stopwatchProceso.ElapsedMilliseconds + procesoE.TiempoTrabajado;

            tablaProcesosCompletados.Rows.Add(
                procesoE.NumeroPrograma,
                procesoE.getExpresion(),
                procesoE.getRespuesta(),
                (procesoE.TiempoMaximoEstimado / 1000).ToString("F2"),
                (procesoE.TiempoLlegada / 1000).ToString("F2"),
                (procesoE.TiempoFinalizado / 1000).ToString("F2"),
                (procesoE.TiempoEspera / 1000).ToString("F2"),
                (procesoE.TiempoTrabajado / 1000).ToString("F2"),
                (procesoE.TiempoRetorno / 1000).ToString("F2"),
                (procesoE.TiempoRespuesta / 1000).ToString("F2")
            );
            VaciarTablaProcesoEjecutando();
        }
        private async void botonIniciar_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            stopwatchGlobal.Start(); // Inicia el temporizador global
            Task loopBloqueosTask = loopAdministrarBloqueos(cts.Token);
            Task loopListosTask = loopAdministrarEspera(cts.Token);
            while ((Cola_procesos_listos.Count + Cola_procesos_bloqueados.Count + Cola_procesos_nuevos.Count) > 0)
            {
                while (((Cola_procesos_listos.Count + Cola_procesos_bloqueados.Count + ((procesoE == null) ? 0 : 1)) < 5) && Cola_procesos_nuevos.Count > 0)
                {
                    Cola_procesos_listos.Enqueue(Cola_procesos_nuevos.Dequeue());
                    if (Cola_procesos_listos.Last().TiempoLlegada < 0)
                    {
                        Cola_procesos_listos.Last().TiempoLlegada = stopwatchGlobal.Elapsed.TotalMilliseconds;
                    }
                }
                if (Cola_procesos_listos.Count > 0)
                {
                    await IniciarSigP(cts.Token);
                    LlenarTablaListos();
                }
                else { await Task.Delay(10); }
            }
            stopwatchGlobal.Stop(); // Detiene el temporizador global
            cajaTiempoGlobal.Text = stopwatchGlobal.Elapsed.TotalSeconds.ToString("F2");
            cajaTiempoProceso.Text = "0.00";
            cts.Cancel();
            await loopBloqueosTask;
            MessageBox.Show($"La ejecución terminó con {stopwatchGlobal.Elapsed.TotalSeconds.ToString("F2")} segundos.", "Final de programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TimerActualizacion_Tick(object sender, EventArgs e)
        {
            if (stopwatchGlobal.IsRunning)
            {
                cajaTiempoGlobal.Text = stopwatchGlobal.Elapsed.TotalSeconds.ToString("F2");
            }
            if (stopwatchProceso.IsRunning)
            {
                cajaTiempoProceso.Text = (((float)procesoE.TiempoTrabajado / 1000) + stopwatchProceso.Elapsed.TotalSeconds).ToString("F2");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
            if (timerActualizacion != null)
            {
                timerActualizacion.Stop();
            }
            base.OnFormClosing(e);
        }

        public async Task loopAdministrarBloqueos(CancellationToken cts)
        {
            while (!cts.IsCancellationRequested)
            {
                while (pausaActiva)
                {
                    await Task.Delay(10); // Espera 10ms antes de volver a verificar
                }
                List<Proceso> TlistaDesB = new List<Proceso>(); // Lista de procesos que deberían salir de la cola bloqueados
                // Actualizar solo los procesos que ya están bloqueados
                if (Cola_procesos_bloqueados.Count > 0)
                {
                    foreach (Proceso Ptemp in Cola_procesos_bloqueados)
                    {
                        bool found = false;
                        // Buscar el proceso en la tabla
                        foreach (DataGridViewRow row in tablaProcesosBloqueados.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == Ptemp.NumeroPrograma.ToString())
                            {
                                // Proceso encontrado, actualizamos la columna de tiempo bloqueado
                                row.Cells[1].Value = (Ptemp.TiempoBloqueado / 1000.0).ToString("F2");
                                found = true;
                                // Si el proceso ha estado bloqueado más de 7 segundos, lo marcamos para desbloquearlo
                                if (Ptemp.TiempoBloqueado >= 7000)
                                {
                                    TlistaDesB.Add(Ptemp);
                                }
                                break; // Salimos del ciclo ya que encontramos el proceso
                            }
                        }
                        // Si no se encontró en la tabla, lo agregamos como nueva fila
                        if (!found)
                        {
                            tablaProcesosBloqueados.Rows.Add(
                                Ptemp.NumeroPrograma.ToString(),
                                (Ptemp.TiempoBloqueado / 1000.0).ToString("F2")
                            );
                        }
                        // Aumentamos el tiempo bloqueado del proceso que se esta viendo
                        Ptemp.TiempoBloqueado += 10;
                        Ptemp.TiempoEspera += 10;
                    }
                }
                // Procesar la lista de procesos desbloqueados
                foreach (Proceso Ptemp in TlistaDesB)
                {
                    Cola_procesos_bloqueados.Remove(Ptemp); //Eliminar proceso de la lista de bloqueados
                    foreach (DataGridViewRow row in tablaProcesosBloqueados.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == Ptemp.NumeroPrograma.ToString())
                        {
                            tablaProcesosBloqueados.Rows.Remove(row);
                            break;//Eliminamos la fila y salimos del ciclo
                        }
                    }
                    //Mover el proceso denuevo a la cola de listos
                    Cola_procesos_listos.Enqueue(Ptemp);
                    LlenarTablaListos();
                }
                await Task.Delay(10);//Espera para no sobrecargar el CPU
            }
        }

        public async Task loopAdministrarEspera(CancellationToken cts)
        {
            while (!cts.IsCancellationRequested)
            {
                while (pausaActiva)
                {
                    await Task.Delay(10); // Espera 10ms antes de volver a verificar
                }
                double Inicio = stopwatchGlobal.Elapsed.TotalMilliseconds;

                // Añadimos un pequeño delay para no sobrecargar la CPU
                await Task.Delay(100);
                if (Cola_procesos_listos.Count > 0)
                {
                    double Fin = stopwatchGlobal.Elapsed.TotalMilliseconds;
                    foreach (Proceso Ptemp in Cola_procesos_listos)
                    {
                        Ptemp.TiempoEspera += (Fin - Inicio) + 1;
                        // Actualizar la tabla
                        bool found = false;
                        foreach (DataGridViewRow row in TablaProcesosListos.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == Ptemp.NumeroPrograma)
                            {
                                // Actualizar la fila existente
                                row.Cells[1].Value = (Ptemp.TiempoMaximoEstimado / 1000).ToString("F2");
                                row.Cells[2].Value = (Ptemp.TiempoTrabajado / 1000).ToString("F2");
                                row.Cells[3].Value = (Ptemp.TiempoEspera / 1000).ToString("F2");
                                found = true;
                                break;
                            }
                        }

                        // Si el proceso no está en la tabla, agregarlo
                        if (!found)
                        {
                            TablaProcesosListos.Rows.Add(
                                Ptemp.NumeroPrograma,                // PID
                                (Ptemp.TiempoMaximoEstimado / 1000).ToString("F2"),   // Tiempo Máximo Estimado
                                (Ptemp.TiempoTrabajado / 1000).ToString("F2"),        // Tiempo Trabajado (Servicio) en segundos
                                (Ptemp.TiempoEspera / 1000).ToString("F2")            // Tiempo Transcurrido (Espera) en segundos
                            );
                        }
                    }
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (stopwatchGlobal.IsRunning || (!stopwatchGlobal.IsRunning && pausaActiva))
            {
                if (e.KeyCode == Keys.P) // Pausa la simulación
                {
                    Debug.WriteLine("Se introdujo P");
                    Pausar();
                }
                else if (e.KeyCode == Keys.C) // Continuar la simulación
                {
                    Debug.WriteLine("Se introdujo C");
                    Continuar();
                }
                else if (e.KeyCode == Keys.I) // Interrumpir el proceso actual
                {
                    Debug.WriteLine("Se introdujo I");
                    Interrumpir();
                }
                else if (e.KeyCode == Keys.E) // Terminar el proceso actual con error
                {
                    Debug.WriteLine("Se introdujo E");
                    ErrorInterupcion();
                }
            }
        }

        private void Pausar()
        {
            pausaActiva = true;
            stopwatchGlobal.Stop();
            stopwatchProceso.Stop();
        }

        private void Continuar()
        {
            if (pausaActiva)
            {
                pausaActiva = false;
                stopwatchGlobal.Start();
                stopwatchProceso.Start();
            }
        }

        private void ErrorInterupcion()
        {
            errorActiva = true;
            pausaActiva = false;
        }

        private void Interrumpir()
        {
            interrupcionActiva = true;
            pausaActiva = false;
        }
    }
}