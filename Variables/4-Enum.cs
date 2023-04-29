using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Enum
    {
        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Week
        {
            Lunes = 1,
            Martes = 2,
            Miercoles = 3,
            Jueves = 4,
            Viernes = 5,
            Sabado = 6,
            Domingo = 7
        }


        static void Main(string[] args)
        {
            // Ejemplo 1
            Console.WriteLine($"This level is: {Level.High}");

            // Ejemplo 2
            int myDay = (int) Week.Viernes;
            Console.WriteLine($"El dia {Week.Viernes} es el numero: {myDay}");

            // Ejemplo 3 en un switch
            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }
    }
}