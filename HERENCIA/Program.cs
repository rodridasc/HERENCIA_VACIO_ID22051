using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    class operacion
        {
            //declaracion de variables
            //tipo de acceso 
            protected int valor1;
            protected int valor2;
            protected int resultado;
            
            //atributos de la clase operacion 
            //metodos o funciones de operacion 

            /* los metodos que se ponen acontinuacion 
             * son las funciones de obtener el valor de la caja de texto y guardarlo en la 
             * memoria dentro de la variable indicada*/
            //constructores 

            public int Valor1
            {
                get { return valor1;  } //vamos por el valor de la caja de texto
                set { valor1 = value; }// guardamos el valor en memoria 
        }
        public int Valor2
        {
            get { return valor2; } //vamos por el valor de la caja de texto
            set { valor2 = value; }// guardamos el valor en memoria 
        }

        public int Resultado
        {
            get { return resultado; } //vamos por el valor de la caja de texto
            set { resultado = value; }// guardamos el valor en memoria 
        }
    }

    //creamos nuestra ckase hijo que usara los metodos de crear dato

    class Sumar:operacion // los : nos dan permiso de usar lo que tienen operacion 
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodo
        //pueden tener variables de uso para ellos 
        //declarar variables esta clases 

        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }

    class Restar : operacion // los : nos dan permiso de usar lo que tienen operacion 
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodo
        //pueden tener variables de uso para ellos 
        //declarar variables esta clases 

        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion // los : nos dan permiso de usar lo que tienen operacion 
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodo
        //pueden tener variables de uso para ellos 
        //declarar variables esta clases 

        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }


    static class Program

    {
        //clase principal o clase padre que guardara los metodos de lectura
        //de valores y almacenado de valoresen variables
       
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
