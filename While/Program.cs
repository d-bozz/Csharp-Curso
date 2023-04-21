using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // El while bucle recorre un bloque de código siempre que una condición específica sea True:
            int i = 0;

            while(i < 10)
            {
                Console.WriteLine("Iteración de i " + i);
                i++;
            }

            int j = 0;
            while (j < 100)
            {
                if (j > 10) 
                    break;

                Console.WriteLine("Iteración de j " + j);
                j++;
            }


            string[] friends = new string[7]{
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
                "Héctor"
            };

            int index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            //El do while bucle es una variante del whilebucle. Este ciclo ejecutará el bloque de código una vez,
            //antes de verificar si la condición es verdadera, luego repetirá el ciclo mientras la condición sea verdadera.
            bool run = false;
            do
            {
                Show();
            } while (run);
        }

        static void Show()
        {
            Console.WriteLine("Entro una vez y ya");
        }

    }
}
