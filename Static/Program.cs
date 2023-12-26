using System;

namespace Static
{
    class Program
    {
        // static significa algo que no se puede instanciar.
        // No se puede crear un objeto de una clase estática y no puede acceder a miembros estáticos usando un objeto.
        static void Main(string[] args)
        {
            People hector = new People()
            {
                Name = "Héctor",
                Age = 34
            };

            People juan = new People()
            {
                Name = "Juan",
                Age = 30
            };

            // ejemplo de clase static es Math
            double dub = -3.14;
            Console.WriteLine(Math.Abs(dub));

            // Puedo contar la cantidad de veces que se utiliza la clase People para construir objetos
            // llamando a la propeidad static
            Console.WriteLine(People.Count);

            // No necesito crear un objeto solo llamo a la clase con el metodo static
            Console.WriteLine(People.GetCount());

        }

        #region Static con una clase
        // Todos los metodos y propiedades dentro deben ser static
        // Se utiliza por ejemplo para definir una clase que contendra metodos con calculos matemticos que no necesitan un objeto
        public static class TemperatureConverter
        {
            public static double CelsiusToFahrenheit(string temperatureCelsius)
            {
                // Convert argument to double for calculations.
                double celsius = Double.Parse(temperatureCelsius);

                // Convert Celsius to Fahrenheit.
                double fahrenheit = (celsius * 9 / 5) + 32;

                return fahrenheit;
            }
        }
        #endregion

        public class People
        {
            // Static con una propiedad
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            // Static con un metodo
            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }
        }
    }
}
