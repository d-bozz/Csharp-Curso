using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo una tupla de nombre product, que contiene dos tipos int y string
            (int id, string name) product = (1, "cerveza stout");

            Console.WriteLine($"{product.id} {product.name}");

            // Edito el valor de la tupla
            product.name = "cerveza porter";

            Console.WriteLine($"{product.id} {product.name}");

            // Otra forma de crear la tupla, mas rapida
            // automaticamente detecta el tipo de datos, y se accede mediante item
            var person = (1, "Héctor");
            Console.WriteLine($"persona {person.Item1} {person.Item2}");

            // Creo un arreglo de tuplas
            var people = new[]
            {
                (1, "Héctor"),
                (2, "Pedro"),
                (3, "Juan")
            };

            // Recorro el arreglo de tuplas e imprimo los elementos
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            // Creo un arreglo de tuplas y le especifico el int y string name
            (int id, string name)[] people2 = new[]
            {
                (1, "Héctor"),
                (2, "Pedro"),
                (3, "Juan")
            };

            // recorro el arreglo de tuplas
            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            // Obtengo los valores de la funcion
            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat} long: {cityInfo.lng} nombre: {cityInfo.name}");

            // Aqui le indico que quiero ignorar el valor 1 y valor 3
            // En este caso solo quiero que me muestre el valor de lat
            var (_, lng, _) = getLocationCDMX();

            Console.WriteLine(lng);
        }

        // Creo un metodo que me devuelve valores mediante tupla
        public static (float lat, float lng, string name) getLocationCDMX()
        {
            float lat = 19.12121f;
            float lng = -99.19212f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    }
}
