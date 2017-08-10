using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nombre:Oscar Emmanuel Feliz Monsanto 13-siin-1-136  seccion: 0463");

            Console.WriteLine("Nombre:Gabriel Sanchez Del Rosario 09-miin-1-126  seccion: 0463");
            
            Console.WriteLine("Nombre:Ismael A. Brito Javier 16-siin-1-057 seccion: 0463");


            {

                int cuenta;

                float saldo, suma;

                string linea;

                suma = 0;

                do

                {

                    Console.Write("Ingrese numero de cuenta:");

                    linea = Console.ReadLine();

                    cuenta = int.Parse(linea);

                    if (cuenta >= 0)

                    {

                        Console.Write("Ingrese Saldo:");

                        linea = Console.ReadLine();

                        saldo = float.Parse(linea);

                        if (saldo > 0)

                        {

                            Console.WriteLine("Saldo Acreedor.");

                            suma = suma + saldo;

                        }

                        else

                        {

                            if (saldo < 0)

                            {
                                Console.WriteLine("Saldo Deudor.");

                            }

                            else

                            {

                                Console.WriteLine("Saldo Nulo.");


                            }
                        }
                    }

                } while (cuenta >= 0);

                Console.Write("Total de saldos Acreedor:");

                Console.Write(suma);

                Console.ReadKey();

            }
        }
    }
}


       
    

    

