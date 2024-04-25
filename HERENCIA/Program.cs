using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    static class Program
    {
        //clase principal o clase padre que guardara los metodos de lectura
        //de valores y almacenado de valoresen variables
        class operacion
        {
            //declaracion de variables
            //tipo de acceso 
            protected int valor1;
            protected int valor2;
            protected int resultado;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
