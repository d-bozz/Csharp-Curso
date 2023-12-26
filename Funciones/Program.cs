using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Show();

            Sum(1,2);

            // Llamo al metodo y le paso solo un parametro
            Opcional("C#");

            ActualizarRef(ref a); //Metodo con ref
            Console.WriteLine($"el valor es: {a}"); // imprime 3

            ActualizarOut(out a); //Metodo con out
            Console.WriteLine($"el valor es: {a}"); // imprime 3
        }

        static void Sum(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        static void Show()
        {
            Console.WriteLine("Hola, soy un texto que se imprime desde función");
        }

        // Sobrecarga de metodos
        // Varios métodos pueden tener el mismo nombre con diferentes parámetros:
        static void Sum(int num1, string cadena)
        {
            Console.WriteLine("Soy la cadena: " + cadena + " Soy el numero: " + num1);
        }

        // Metodo con parametros opcionales
        static void Opcional (string curso, string nombre = "Joel", int cantidad = 69)
        {
            Console.WriteLine($"Mi nombre es {nombre} estoy tomando el curso de {curso} y tengo la cantidad de {cantidad}");
        }

        // Utilizar ref significa que vas a pasar el valor por referencia a un método, 
        // lo que implica que el valor va a cambiar dentro del método. 
        // Además, si deseamos utilizar ref la variable tiene que estar inicializada 
        // con anterioridad.
        public static void ActualizarRef(ref int valor)
        {
            valor += 2;
        }

        // Utilizar out significa que la asignación del valor de esa variable está dentro del 
        // método al que se llama. No es necesario inicializar el valor de la variable, 
        // aunque si debemos instanciarla.
        public static void ActualizarOut(out int valor)
        {
            valor = 13;
        }

        // La palabra clave in evita que podamos modificar el valor de la variable dentro del 
        // método, por lo que el valor siempre será el que hayamos pasado previamente.
        public static void ActualizarIn(in int valor)
        {
            Console.WriteLine($"el valor es: {valor}");
        }
    }
}
