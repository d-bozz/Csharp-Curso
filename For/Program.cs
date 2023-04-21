using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]{
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
            };

            //Cuando sepa exactamente cuántas veces desea recorrer un bloque de código, use el forbucle en lugar de un whilebucle:
            bool run = true;
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

            //Bucle anidado
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Se ejecuta 2 veces

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Se ejecuta 6 veces (2 * 3)
                }
            }

        }
    }
}
