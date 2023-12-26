using System;

namespace TiposNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# nos permite modificar los tipos para que estos sean nullables.
            // Esta acción se realiza indicando el carácter ? después del tipo de dato que va a ser.

            int? enteroNulo = null;
            enteroNulo = 123;

            // Propiedades de los tipos nullables:
            // Podríamos comparar si la variable enteroNulo tiene un valor y si no lo tiene, asignarlo.

            if (enteroNulo.HasValue)
            {
                int enteroNormal = enteroNulo.Value;
                Console.WriteLine("enteroNormal: " + enteroNormal);
            }
        }
    }
}