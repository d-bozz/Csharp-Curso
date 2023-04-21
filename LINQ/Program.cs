using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
// Preciso importar el paquete Linq

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo una lista de objetos Beer
            List<Beer> beers = new List<Beer>()
            {
                new Beer(){
                    Name="Corona", Country="México", People=20
                },
                new Beer()
                {
                    Name="Delirium", Country="Bélgica", People=50
                },
                 new Beer()
                {
                    Name="Erdinger", Country="Alemania", People = 60
                }
            };

            
            // Genero un IEnumerable con nombre
            var beersNameReal = from b in beers
                                select new
                                {
                                    Name = b.Name
                                };

            // Realizo lo anterior con expresiones lambda
            var beersNameReal2 = beers.Select(x => x.Name);


            // Obtengo un IEnumerable filtrando por country 
            var beersMéxico = from b in beers
                              where b.Country == "México"
                              || b.Country =="Alemania"
                              select b;

            // Relizo lo anterior con expresiones lambda
            var beersMéxico2 = beers.Select(x => x.Country == "Mexico" || x.Country == "Alemania");


            // Obtengo un IEnumerable ordenando por pais de forma descendente
            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b;

            // Puedo hacer lo mismo utilizando expresiones lambda
            var orderedBeersDesc = beers.OrderByDescending(x => x.Country);


            // Puedo ordenar de forma ascendente
            var orderedBeersAsc = beers.OrderBy(x => x.Country);


            // Podemos usar el método GroupBy() para agrupar elementos en función de la clave especificada.
            var studentListGroupByCity = beers.GroupBy(x => x.Country);


            // Podemos usar All() para determinar si todos los elementos de una secuencia satisfacen una condición:
            var hasAllBeerPassed = beers.All(x => x.People > 50);


            //  Podemos usar Any()para determinar si algún elemento de una secuencia existe o cumple una condición:
            var hasAnyBeerGotDistinction = beers.Any(x => x.People > 86);


            // Skip() omitirá un número específico de elementos en una secuencia y devolverá los elementos restantes:
            var skipBeersUptoIndexTwo = beers.Skip(2);
            

            // Take() devolverá un número específico de elementos desde el primer elemento en una secuencia:
            var takeBeersUptoIndexTwo = beers.Take(2);
        

            // La aplicación del Sum()método en la propiedad people dará la suma de todas las personas:
            var sumOfBeers = beers.Sum(x => x.People);


            // Podemos utilizar el método Count() para devolver el número de personas con una puntuación superior a 65: 
            var countOfBeers = beers.Count(x => x.People > 65);


            // Max() mostrará la Markpuntuación más alta de un estudiante de la colección:
            var maxMarks = beers.Max(x => x.People);


            //Min() mostrará las calificaciones más bajas obtenidas por un estudiante de la colección:
            var minMarks = beers.Min(x => x.People);
            

            //Podemos usar Average()para calcular el promedio de una secuencia de valores numéricos:
            var avgMarks = beers.Average(x => x.People);

            // devuelve el primer valor, en caso de no encontrar devuelve null
            var firstOrDefaultBeer = beers.FirstOrDefault(x => x.Name == "Mexico");
        }
    }

    // Creo la clase Beer con dos parametros
    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int People { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} País: {Country} Cantidad de personas: {People}";
        }
    }
}
