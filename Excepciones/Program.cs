using System;
using System.IO;
// Utilizo el paquete IO para trabajar con las excepciones

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intento lo que esta en el bloque de try
            try
            {
                string content = File.ReadAllText(@"C:\Users\Bioxor\Documents\x\pato.txt");
                Console.WriteLine(content);

                // Arrojo una excepcion
                throw new Exception("Ocurrio algo raro");
            }
            // Implemento la excepcion al no encontrar el archivo
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            // Implemento una excepcion generica
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Se ejecuta siempre caiga o no en la excepcion
            finally
            {
                Console.WriteLine("Aquí me he ejecutado, pase lo que pase");
            }

            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}
