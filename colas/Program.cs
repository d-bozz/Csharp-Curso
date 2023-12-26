using System;

namespace colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> marcas = new Queue<string>();
            marcas.Enqueue("Audi");
            marcas.Enqueue("Opel");
            marcas.Enqueue("BMW");


            // Para recibir elementos de una cola tenemos dos opciones.
            // Peek, el cual es un método que nos devuelve el valor del primer elemento, pero no lo remueve de la cola.
            // Dequeue el cual devuelve el elemento y lo elimina de la cola

            Console.WriteLine($"La primera marca es {marcas.Peek()}"); //Audi
            Console.WriteLine($"La primera marca (otra vez) es {marcas.Dequeue()}"); //Audi
            Console.WriteLine($"La segunda marca es {marcas.Dequeue()}"); //Opel

            // Podemos iterar sobre la cola
            foreach (string marca in marcas)
            { 
                Console.WriteLine(marca);
            }

            // Podemos limpiar la cola
            marcas.Clear();

            // Podemos verificar si un elemento esta en la cola
            marcas.Contains("Audi");

            // Podemos ver el tamaño de la cola
            marcas.Count();
        }
    }
}