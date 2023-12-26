using System;
using System.Linq;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 5, 1, 8, 9 };
            string[] friends = new string[8]{
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
                null,
                null
            };

            friends[0] = "Héctor";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);


            // Ordenar array
            Array.Sort(friends);
            foreach (string friend in friends)
            { 
                Console.WriteLine(friend);
            }


            // Obtener el Max, Min y Sum
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements


            // Array bidimensional
            double[,] arrayMultidimensional = new double[2, 2] { {6, 3.0}, {6.3, 5.6} };
            Console.WriteLine(arrayMultidimensional[1,1]); // imprime fila 1 columna 1 = 5.6

            // recorrer una matriz bidireccional
            foreach (int i in arrayMultidimensional)
            {
                Console.WriteLine(i);
            }
        }

    }
}
