using System;
using static System.Net.Mime.MediaTypeNames;

namespace EntradaDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se utiliza Console.ReadLine() para obtener la entrada del usuario.

            #region Ejemplo 1
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            #endregion

            #region Ejemplo 2
            Console.WriteLine("Enter your age:");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);
            #endregion

        }
    }
}