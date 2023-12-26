using System;

namespace SenenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;

            // Cuando solo tiene una linea no es necesario usar corchetes
            if (areYouHungry && IsOpenRestaurant("Lonches juan",11))
                Console.WriteLine("Come");
            else
                Console.WriteLine("No comes");

            // Lo mismo que lo anterior pero usando operadores ternarios
            string result = (areYouHungry && IsOpenRestaurant("Lonches juan", 11)) ? "Come" : "No comes";
            Console.WriteLine(result);
        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if (name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name =="Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
