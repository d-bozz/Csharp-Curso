using System;
using System.Runtime.ConstrainedExecution;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //La abstracción de datos es el proceso de ocultar ciertos detalles y mostrar solo la información esencial al usuario.

            Pig myPig = new Pig(); // Se crea un objeto Pig
            myPig.animalSound();  // Se llama a un metodo abstracto
            myPig.sleep();  // Se llama a un metodo regular
        }

        // Clase abstracta: es una clase restringida que no se puede usar para crear objetos
        // para acceder a ella, se debe heredar de otra clase

        abstract class Animal
        {
            // Método abstracto: solo se puede usar en una clase abstracta y no tiene cuerpo.
            // El cuerpo lo proporciona la clase derivada
            public abstract void animalSound();
            
            // Metodo regular
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Clase derivada (Pig hereda de Animal)
        class Pig : Animal
        {
            public override void animalSound()
            {
                // El cuerpo de animalSound() es creado aqui
                Console.WriteLine("The pig says: wee wee");
            }
        }
    }
}
