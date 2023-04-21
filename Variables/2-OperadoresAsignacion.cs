using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class OperadoresAsignacion
    {
        static void Main(string[] args)
        {
            int valor1 = 9;
            int valor2 = 2;

            // A lo actual de Valor2 se le suma y asigna lo de valor1 
            valor2 += valor1;
            Console.WriteLine(valor2); // Imprime 11

            // A lo actual de Valor2 se le resta y asigna lo de valor1 
            valor2 -= valor1;
            Console.WriteLine(valor2); // Imprime 7

            // A lo actual de Valor2 se le multiplica y asigna lo de valor1 
            valor2 *= valor1;
            Console.WriteLine(valor2); //Imprime 18

            // A lo actual de Valor2 se le divide y asigna lo de valor1 
            valor2 /= valor1;
            Console.WriteLine(valor2); //Imprime 4

            // A lo actual de Valor2 se le divide, toma el resto y se lo asigna  
            valor2 %= valor1;
            Console.WriteLine(valor2); //Imprime 1, esto ya que 9/2 = 4 con resto = 1
        }
    }
}
