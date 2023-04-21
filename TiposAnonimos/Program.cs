using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un objeto anonimo, sin tipo.
            // Los objetos anonimos no necesitan una clase para ser creados.
            // La desventaja es que el objeto es readonly y no puede ser modificado
            var hector = new
            {
                Name= "Héctor",
                Country ="México",
            };

            Console.WriteLine($"{hector.Name} {hector.Country}");

            var beers= new[]
            {
                // Los objetos anonimos deben tener la misma estructura todos,
                // es decir no puedo ponerle a uno 2 elementos y al siguiente 3
                new { Name ="Red", Brand ="Delirium"},
                new { Name="London Porter", Brand="Fullers"}
            };

            foreach (var b in beers)
            {
                Console.WriteLine($"cerveza {b.Name} {b.Brand}");
            }

        }
    }
}
