using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class OperadoresComprobacion
    {
        static void Main(string[] args)
        {
            int valor1 = 9;
            int valor2 = 2;
            int valor3 = 9;

            var data = valor1 < valor2;
            Console.WriteLine(data); // devuelve false

            data = valor1 > valor2;
            Console.WriteLine(data); // devuelve true

            data = valor1 <= valor3;
            Console.WriteLine(data); // devuelve true

            data = valor1 >= valor3;
            Console.WriteLine(data); // devuelve true

            data = valor1 == valor2;
            Console.WriteLine(data); // devuelve false

            data = valor1 != valor2;
            Console.WriteLine(data); // devuelve true
        }
    }
}
