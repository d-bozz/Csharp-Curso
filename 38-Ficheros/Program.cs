using System;

namespace Ficheros
{
    class Comentarios
    {
        static void Main(string[] args)
        {
            leerFichero();
            //modificarFichero();
            //escribirFichero();
        }
        
        public static void leerFichero()
        {
            //Accedemos al fichero
            using (StreamReader reader = new StreamReader("C:\\Damian\\csharp-basics\\38-Ficheros\\Ejemplo.txt"))
            {
                string text;
                while ((text = reader.ReadLine()) != null) //Leemos línea por línea
                {
                    Console.WriteLine(text);
                }
            }
        }

        public static void modificarFichero()
        {
            string[] paises = new string[] { "USA", "Inglaterra", "Alemaia" };
            using (StreamWriter writer = new StreamWriter("C:\\Damian\\csharp-basics\\38-Ficheros\\Ejemplo.txt"))
            {
                foreach (string item in paises)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static void escribirFichero()
        {
            string[] paises = new string[] { "USA", "England", "Germany" };
            string ciudadAlFinal = "Lima";

            // Crea el archivo y le ingresa todo el texto en crudo
            File.WriteAllText("C:\\Damian\\csharp-basics\\38-Ficheros\\Ejemplo.txt", "China Japon Korea");

            // Crea el archivo y lo llena con los paises
            File.WriteAllLines("C:\\Damian\\csharp-basics\\38-Ficheros\\Ejemplo.txt", paises);

            // Añadimos una linea al final del texto
            File.AppendAllText("C:\\Damian\\csharp - basics\\38 - Ficheros\\Ejemplo.txt", ciudadAlFinal);
        }
    }
}