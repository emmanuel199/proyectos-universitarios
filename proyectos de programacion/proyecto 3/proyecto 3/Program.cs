using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace proyecto_3


{
    class Cliente

    {
        private string nombre;

        private int monto;

        public Cliente(string nom)

        {

            nombre = nom;

            monto = 0;

        }

        public void Depositar(int m)

        {

            monto = monto + m;

        }

        public void Extraer(int m)

        {

            monto = monto - m;

        }

        public int RetornarMonto()

        {

            return monto;
        }

        public void Imprimir()

        {

            Console.WriteLine(nombre + "tiene depositado la suma de " + monto);

        }
    }

    class Banco

    {

        private Cliente cliente1, cliente2, cliente3;

        public Banco()

        {

            cliente1 = new Cliente("Daniela la Banquera");

            cliente2 = new Cliente("Mandrake el de Asabache");

            cliente3 = new Cliente("Josefa la Licuadora");

        }

        public void Operar()

        {

            cliente1.Depositar(400);

            cliente2.Depositar(8000);

            cliente3.Depositar(2000);

            cliente3.Extraer(500);

        }

        public void DepositosTotales()

        {

            int t = cliente1.RetornarMonto() +

                    cliente2.RetornarMonto() +

                    cliente3.RetornarMonto();

            Console.WriteLine("El total de dinero en el banco es:" + t);

            cliente1.Imprimir();

            cliente2.Imprimir();

            cliente3.Imprimir();

        }

        static void Main(string[] args)

        {
            Console.WriteLine("Nombre: Emmanuel Feliz: 13-siin-1-136 seccion: 0463");

            Console.WriteLine("Nombre: Ismael Brito: 16--siin-1-057  seccion: 0463");

            Console.WriteLine("Nombre: Gabriel S.Del Rosario: 09-miin-1-126 seccion: 0463");

            Banco banco1 = new Banco();

            banco1.Operar();

            banco1.DepositosTotales();

            Console.ReadKey();

        }
    }
}
