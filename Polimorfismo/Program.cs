using System;

namespace Polimorfismo
{
    class Program
    {
        // El polimorfismo nos permite  diseñar objetos que pueden tener varios comportamientos,
        // lo que nos permite procesar objetos de diferentes maneras.

        class Animal  // Clase base (padre) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Clase derivada (hija) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Clase derivada (hija) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        // C# proporciona una opción para anular el método de la clase base,
        // agregando la palabra clave virtual al método dentro de la clase base y usando la palabra clave override
        // para cada método de clase derivada.
    }
}
