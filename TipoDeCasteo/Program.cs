using Microsoft.VisualBasic;
using System;

namespace TipoDeCasteo
{
    class Program
    {
        static void Main(string[] args)
        {
            // La conversión de tipos es cuando asigna un valor de un tipo de datos a otro tipo.

            // Casting implícito(automáticamente): conversión de un tipo más pequeño a un tamaño de tipo más grande
            // char-> int-> long-> float->double

            // Casting explícito(manualmente): conversión de un tipo más grande a un tipo de tamaño más pequeño
            // double-> float-> long-> int->char

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convertir int a string
            Console.WriteLine(Convert.ToDouble(myInt));    // convertir int a double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convertir double a int
            Console.WriteLine(Convert.ToString(myBool));   // convertir bool a string
        }
    }
}
