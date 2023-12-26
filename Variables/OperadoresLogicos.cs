using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class OperadoresLogicos
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x > 3 && x < 10); // devuelve True
            Console.WriteLine(x > 3 || x < 4); // devuelve True
            Console.WriteLine(!(x > 3 && x < 10)); // devuelve False
        }
    }
}
