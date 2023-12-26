using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // El tipo Stack es una colección que almacena elementos de forma LIFO (last in first out),
            // lo que quiere decir que el último elemento que ha entrado, va a ser el primero de la lista.

            // Crear un stack y añadir elementos
            Stack<string> marcas = new Stack<string>();
            marcas.Push("Audi");
            marcas.Push("Opel");
            marcas.Push("BMW");


            // Recibir elementos de un stack
            // Pop() el cual nos devolverá el último elemento insertado en dicho stack, y lo remueve del mismo.
            // Peek() el cual nos devuelve el elemento sin eliminarlo de la cola.
            Console.WriteLine($"La última marca insertada es {marcas.Peek()}"); //BMW
            Console.WriteLine($"La última marca insertada (otra vez) es {marcas.Pop()}"); //BMW
            Console.WriteLine($"La penúltima marca insertada es {marcas.Pop()}"); //Opel

            // Recorrer un stack
            foreach (string marca in marcas)
            { 
                Console.WriteLine(marca); 
            }

            // Limpiar un stack
            marcas.Clear();

            // Verificar un elemento en stack
            marcas.Contains("Audi");
        }
    }
}