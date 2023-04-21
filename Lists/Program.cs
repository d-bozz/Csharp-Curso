using System;
using System.Collections.Generic;
// Para usar una lista tengo que usar el paquete Generic

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo una lista de numeros y le agrego valores de manera individual
            // El metodo add agrega valores al final de la lista
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(2);

            // Obtengo la cantidad de elementos
            Console.WriteLine(numbers.Count);

            // Creo una lista de numeros y le agrego valores desde la creacion
            List<int> numbers2 = new List<int>() { 
                1,6,7,10,14
            };

            Console.WriteLine(numbers2.Count);

            // Agrego un valor a la lista
            numbers2.Add(55);
            Console.WriteLine(numbers2.Count);

            // Elimino todos los elementos de la lista
            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            // Creo una lista de strings
            List<string> countries = new List<string>()
            {
                "México","Argentina","España"
            };
            Console.WriteLine(countries.Count);

        }
    }
}
