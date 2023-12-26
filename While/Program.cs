using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // El while bucle recorre un bloque de código siempre que una condición específica sea True:
            int iterador = 0;
            while (iterador <= 10)
            {
                iterador++;
                Console.WriteLine("Iteracion " +  iterador);
            }
        }
    }
}
