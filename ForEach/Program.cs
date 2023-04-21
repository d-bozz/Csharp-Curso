using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {

        static void Main(string[] args)
        {
            // Esto es lo mismo que hacer: List <int> = new List<int>()
            // Esto es lo mismo que hacer: List <int> numbers = new()
            var numbers = new List<int>()
            {
                23,3,5,10,22,12
            };

            // Recorro la lista numbers con el elemento individual number
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Recorro la lista de objetos de la clase People
            var students = new List<People>()
            {
                new People(){ Name ="Héctor", Country="México"},
                new People(){ Name ="Roberto", Country="Argentina"},
                new People(){ Name ="Ana", Country="Estados Unidos"},
            };

            // Llamo al metodo y le paso la lista de people
            Show(students);

            // Elimino el elemento de la posicion 0
            students.RemoveAt(0);

            Show(students);
        }

        // Creo un metodo que acepte una lista de objetos People y muestre nombre y pais
        static void Show(List<People> students)
        {
            Console.WriteLine("-- Personas --");
            foreach (var people in students)
            {
                Console.WriteLine($"Nombre: {people.Name}, País: {people.Country}");
            }
        }
    }

    // Creo una clase para recorrer por e foreach
    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
