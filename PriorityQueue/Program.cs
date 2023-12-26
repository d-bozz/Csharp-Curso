using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una PriorityQueue y añadir elementos
            PriorityQueue<string, int> colaPrioridad = new PriorityQueue<string, int>();

            colaPrioridad.Enqueue("Opel", 2);
            colaPrioridad.Enqueue("Audi", 1);
            colaPrioridad.Enqueue("BMW", 3);

            // Recibir elementos de una PriorityQueue
            string resultPeek = colaPrioridad.Peek();
            string resultDequeue = colaPrioridad.Dequeue();
            string resultDequeue2 = colaPrioridad.EnqueueDequeue("Mazda", 3);
            Console.WriteLine(resultPeek); //Audi
            Console.WriteLine(resultDequeue); //Audi otra vez
            Console.WriteLine(resultDequeue2); //Opel

            // Eliminar elementos de una PriorityQueue
            colaPrioridad.Clear();
        }
    }
}