using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo una lista de numeros
           List<int> numbers = new List<int>()
           {
               4,3,5,19
           };

            Show(numbers);

            // Inserto elementos indicando la posicion y el valor
            numbers.Insert(1, 6);

            Show(numbers);

            // Contains verifica si el elemento existe en la lista
            Console.WriteLine(numbers.Contains(19) ? "existe" : "no existe");

            // IndexOf me devuelve la posicion del elemento
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);

            // Si el elemento no existe me devuelve un -1
            pos = numbers.IndexOf(100);
            Console.WriteLine(pos);

            // Sort me permite ordenar los elementos de la lista del menor al mayor.
            numbers.Sort();
            Show(numbers);

            // Add Range me permite agregar un rango de elementos
            var numbers2 = new List<int>()
            {
                300,200,400
            };
            numbers.AddRange(numbers2);

            Show(numbers);

        }

        // Creo un metodo para imprimir los elementos de la lista
        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
