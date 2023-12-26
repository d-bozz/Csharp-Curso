using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // El bucle do while recorre el bloque de código al menos una vez mientras la condicion sea True:
            int iterador = 25;
            do
            {
                iterador++;
                Console.WriteLine("Iteracion " + iterador);
            }

            while (iterador <= 10);
        }
    }
}
