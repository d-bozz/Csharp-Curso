using System;
using System.IO;
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };

            // Convierto el objeto myBear a formato JSON
            string json = JsonSerializer.Serialize(myBeer);

            // Convierto el JSON a mi objeto myBear
            Beer beer = JsonSerializer.Deserialize<Beer>(json);


            // Crear un JSON file
            string fileName = "BeerFile.json";
            string jsonString = JsonSerializer.Serialize(beer);
            File.WriteAllText(fileName, jsonString);


            Beer[] beers = new Beer[]{
                new Beer()
                {
                    Name = "Pikantus",
                    Brand = "Erdinger"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                }
            };

            // Convierto el arreglo bears a formato JSON
            string json2 = JsonSerializer.Serialize(beers);

            // Convierto el JSON a un arreglo
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
