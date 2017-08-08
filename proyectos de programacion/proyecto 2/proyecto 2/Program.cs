using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_2
{
    class PruebaVector
    {


        static string[] nombres; // declaramos un vector de tipo estring para los nombres
        private float[] sueldos; //declaramos un vector de tipo float para los sueldos
        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            for (int f = 0; f < nombres.Length; f++)
            {

                Console.Write("Ingrese el nombre del empleado " + (f + 1) + ": ");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo " + (f + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }
        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;

                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombres[pos]);
            Console.WriteLine("tiene un sueldo de :" + mayor);
        }
        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();

            Console.WriteLine("Nombre: Emmanuel Feliz: 13-siin-1-136 seccion: 0463");

            Console.WriteLine("Nombre: Ismael Brito: 16--siin-1-057  seccion: 0463");

            Console.WriteLine("Nombre: Gabriel S.Del Rosario: 09-miin-1-126 seccion: 0463");

            pv.Cargar();
            pv.MayorSueldo();
        }
    }
}
