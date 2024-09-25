using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Practica5_Planificador_FCFS
{
    public partial class Form1 : Form
    {
        private Queue<Proceso> Cola_procesos_nuevos = new Queue<Proceso>();
        private char[] simbolos = { '+', '-', '*', '/', '%' };
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {

        }

        private void Formulario_Ejecuccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicializar();
        }
        private void botonEjecutar_Click(object sender, EventArgs e)
        {
            if (cajaValorRegistros.Value <= 0)
            {
                MessageBox.Show("El valor a registrar debe ser mayor a 0.");
                return;
            }
            for (int i = 0; i < cajaValorRegistros.Value; i++)
            {
                Proceso nuevoProceso = crearProcesoRandom();
                Cola_procesos_nuevos.Enqueue(nuevoProceso);
            }
            Formulario_Ejecuccion f = new Formulario_Ejecuccion();
            f.InicializarCola(Cola_procesos_nuevos);
            f.Show();
            contador = 0;
        }

        public Proceso crearProcesoRandom()
        {
            Random rnd = new Random();

            char operacion = simbolos[rnd.Next(simbolos.Length)];

            float dato1 = rnd.Next(0, 101); // Genera un entero entre 0 y 100
            float dato2 = rnd.Next(0, 101); // Genera un entero entre 0 y 100

            int tiempoMaximoEstimado = rnd.Next(5, 21);

            Proceso nuevoProceso = new Proceso(operacion, dato1, dato2, tiempoMaximoEstimado, ++contador);

            return nuevoProceso;
        }
    }
}
