using System;
using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Damian";
            string lastName = " Boz";

            Console.WriteLine(name.ToUpper());   // Outputs "DAMIAN"
            Console.WriteLine(name.ToLower());   // Outputs "damian"

            // Concatenacion de cadenas
            Console.WriteLine("Hola " + name + lastName);

            // Interpolación de cadenas
            string fullName = $"Mi nombre completo es: {name} {lastName}";

            // Acceder a caracteres de la cadena
            Console.WriteLine(name[0]);  // Outputs "D"

            // Posicion del caracter de una cadena
            Console.WriteLine(name.IndexOf("i"));  // Outputs "3"

            // Cortar la cadena a partir del indice indicado
            string exName = "John Doe";
            int charPos = name.IndexOf("D");
            string getLastName = fullName.Substring(charPos);

            // Insertar una comilla doble en una cadena
            string doubleQuote = "We are the so-called \"Vikings\" from the north.";

            //Insertar una comilla simple en una cadena
            string singleQuote = "It\'s alright.";

            // Insertar una barra invertida en la cadena de caracteres
            string backSlash = "The character \\ is called backslash.";

            // Insertar un salto de linea
            string newLine = "Hello\nWorld!";

            // Insertar un tab
            string tab = "Hello\tWorld!";

            //Insertar un backspace
            string backSpace = "Hello\bWorld!";

            // Indicar multi-linea en una cadena
            string str2 = @"this is a 
                            multi line 
                            string";
        }
    }
}