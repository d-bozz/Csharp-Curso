using System;

namespace Variables
{
    class Variables
    {
        readonly int valor = 23; // solo lectura

        static void Main(string[] args)
        {
            // Variables
            int number1 = 1;
            int number2 = 2;

            // Imprimo el valor de la variable
            Console.WriteLine(number1);

            // Reasigno el valor de la variable number1
            number1 = 3;

            Console.WriteLine(number1);

            // Creo una variable con la suma de las variables
            int suma = number1 + number2;

            Console.WriteLine(suma);

            // Constantes
            const int myNum = 15;
        }
    }
}
