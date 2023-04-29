using System;

namespace TipoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Héctor";
            bool myBool = false;
            char myChar = 'A';
            int myInt = 12121;
            long myLong = 128;
            double myDouble = 12.1212d;
            float myFloat = 5.75f;
            decimal myDecimal = 6.25m;

            int numeroInt = new int();
            Console.WriteLine(numeroInt); // Esto imprime 0

            int? numeroNull = null;
            Console.WriteLine(numeroNull); // Esto imprime un null

        }
    }
}
