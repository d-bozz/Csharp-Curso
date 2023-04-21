using System;

namespace Variables
{
    class Variables
    {
        // variable de solo lectura, no se le asigna valores
        readonly int valor = 23;

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
            int resta = number1 - number2;
            int multiplicacion = number1 * number2;
            int division = number1 / number2;

            Console.WriteLine(suma);

            // Constantes
            const int myNum = 15;
        }
    }
}
