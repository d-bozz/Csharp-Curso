using System;

namespace FuncionesRecursivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialRecursivo(2));   
        }

        /// <summary>
        /// La recursividad es un concepto que se indica cuando un método se llama a si mismo. 
        /// </summary>
        public static int FactorialRecursivo(int numero)
        {
            if (numero == 0) return 1;
            return numero * FactorialRecursivo(numero - 1);
        }
    }
}
