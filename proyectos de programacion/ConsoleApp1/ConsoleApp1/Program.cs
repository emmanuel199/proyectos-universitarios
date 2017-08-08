using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyeto_3

{
    class Clientes

    {
        private String nombre;

        private int monto;

        public Clientes(string nom)

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

            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {

        private Clientes cliente1, cliente2, cliente3;

        public Banco()

        {
            cliente1 = new Clientes("Ramona la licuadora");

            cliente2 = new Clientes("Antonio el perico");

            cliente3 = new Clientes("El fatal de la bachata");

        }

        public void Operar()

        {

            cliente1.Depositar(2500);

            cliente2.Depositar(50);

            cliente3.Depositar(8000);

            cliente3.Extraer(1500);

        }

        static void Main(string[] args)

        {

        }
    }
}

