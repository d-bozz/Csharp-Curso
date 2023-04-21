using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
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

            friends[7] = "Carlos";

            Console.WriteLine(friends[7]);

            // Array bidimensional
            double[,] arrayMultidimensional = new double[2, 2] { {6, 3.0}, {6.3, 5.6} };
            Console.WriteLine(arrayMultidimensional[1,1]); // imprime fila 1 columna 1 = 5.6
        }
    }
}
