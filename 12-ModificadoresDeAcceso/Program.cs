using System;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modificadores de acceso");

        }

        public class ModificadoresDeAcceso
        {
            public string accesoPublico; // El codigo accesible por todas las clases.
            private string accesoPrivado; // El codigo es accesible dentro de la misma clase.
            protected string accesoProtegido; // El codigo es accesible de la misma clase o de la clase que hereda de ella.
            internal string accesoInterno; // El codigo es accesible solo desde el mismo Assembly.
        }
    }
}