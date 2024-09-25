using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_Planificador_FCFS
{
    public class Proceso
    {
        public char Operacion { get; set; } // +, -, *, /, %
        public float Dato1 { get; set; }
        public float Dato2 { get; set; }
        public int TiempoMaximoEstimado { get; set; } // Milisegundos
        public int NumeroPrograma { get; set; }
        public double TiempoTrabajado { get; set; } // Milisegundos trabajados
        public double TiempoLlegada { get; set; } // Tiempo global cuando pasó de "Nuevo" a "Listo"
        public double TiempoFinalizado { get; set; } // Tiempo global cuando pasó de "Listo" a "Terminado"
        public double TiempoRespuesta { get; set; } // Tiempo cuando el proceso entró a memoria por primera vez
        public double TiempoBloqueado { get; set; }
        public double TiempoRetorno { get; set; }
        public double TiempoEspera { get; set; }
        public bool PrimeraLlegada { get; set; }


        public Proceso(char operacion, float dato1, float dato2, int tiempoMaximoEstimado, int numeroPrograma)
        {
            Operacion = operacion;
            Dato1 = dato1;
            Dato2 = dato2;
            TiempoMaximoEstimado = tiempoMaximoEstimado * 1000; // Convertir a milisegundos
            NumeroPrograma = numeroPrograma;
            TiempoTrabajado = 0;
            TiempoLlegada = -1; // Inicializar con -1 (no ha llegado)
            TiempoFinalizado = -1; // No ha terminado
            TiempoRespuesta = -1; // No ha entrado a memoria
            TiempoEspera = 0;
        }

        // Método para obtener la descripción del proceso
        public override string ToString()
        {
            return $"ID: {NumeroPrograma}, Operación: {Operacion} ({Dato1}, {Dato2}), Tiempo: {TiempoMaximoEstimado} segundos";
        }

        public string getExpresion()
        {
            return $"{Dato1} {Operacion} {Dato2}";
        }

        public string getRespuesta()
        {
            string resultado = "";
            switch (this.Operacion)
            {
                case '+': resultado = $"{Dato1 + Dato2}"; break;
                case '-': resultado = $"{Dato1 - Dato2}"; break;
                case '*': resultado = $"{Dato1 * Dato2}"; break;
                case '/':
                    if (Dato2 == 0.0) { resultado = "Error división por 0"; }
                    else { resultado = $"{Dato1 / Dato2}"; }
                    break;
                case '%':
                    if (Dato2 == 0.0) { resultado = "Error división por 0"; }
                    else { resultado = $"{Dato1 % Dato2}"; }
                    break;
            }
            return resultado;
        }
        public void calcularRetorno()
        {
            TiempoRetorno = TiempoFinalizado - TiempoLlegada;
        }
        public void calcularEspera()
        {
            TiempoEspera = TiempoRetorno - TiempoTrabajado;
        }
    }

}
