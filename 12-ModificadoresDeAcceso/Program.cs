using System;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modificadores de acceso");

            var ejemploModificadores = new ModificadoresDeAcceso();
            ejemploModificadores.accesoPublic = "Funciona";
            ejemploModificadores.accesoInternal = "Funciona";
        }

        public class ModificadoresDeAcceso
        {
            public string accesoPublic { get; set; }   //El codigo accesible por todas las clases.
            private string accesoPrivate { get; set; }  //El codigo es accesible dentro de la misma clase.
            protected string accesoProtected { get; set; }  //El codigo es accesible de la misma clase o de la clase que hereda de ella.
            internal string accesoInternal { get; set; }    //El codigo es accesible solo desde el mismo Assembly.

            public ModificadoresDeAcceso()
            {
                accesoPrivate = "Funciona";
            }
        }

        public class ModificadoresHija : ModificadoresDeAcceso
        {
            public ModificadoresHija()
            {
                accesoProtected = "Funciona";
            }
        }
    }
}