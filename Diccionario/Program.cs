using System;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización y crear a valores
            Dictionary<string, string> comunidadesCapitales = new Dictionary<string, string>()
            {
                {"Aragon", "Zaragoza"},
                {"Navarra", "Pamplona"}
            };

            // Añadir valores
            comunidadesCapitales.Add("Castilla la mancha", "Toledo");

            // Acceder a los elementos de un diccionario
            Console.WriteLine(comunidadesCapitales["Aragon"]); //devuelve Zaragoza

            // Acceder a un elemento por posicion
            KeyValuePair<string, string> resultado = comunidadesCapitales.ElementAt(0);
            Console.WriteLine(resultado.Value); //devuelve Zaragoza

            // La forma óptima de acceder a los elementos en un diccionario
            if (comunidadesCapitales.TryGetValue("Aragon", out string resultadoCapital))
                Console.WriteLine(resultadoCapital); //zaragoza
            else
                Console.WriteLine("el parámetro no existe");

            // Actualizar elementos en un diccionario
            if (comunidadesCapitales.ContainsKey("Aragon"))
                comunidadesCapitales["Aragon"] = "Teruel Existe";

            // Eliminar elementos de un diccionario
            comunidadesCapitales.Remove("Aragon");
            comunidadesCapitales.Clear();
        }
    }
}