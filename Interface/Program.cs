using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una interfaz define un contrato
            // Cualquier clase o estructura que implemente ese contrato debe proporcionar una implementación
            // de los miembros definidos en la interfaz

            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburonsin",56),
                new Shark("Jaws", 65)
            };

            IFish[] fishs = new IFish[]
            {
                new Siren(100),
                new Shark("Tiburonsin", 56)
            };


            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fishs);
        }

        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("- Mostramos los animales --");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }
        public static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine("- Mostramos los peces --");
            int i = 0;
            while (i< fishs.Length)
            {
                Console.WriteLine(fishs[i].Swim());
                i++;
            }
        }
    }

    // Al utilizar la intefaz de IFish se debe haces uso de las propiedades y metodos del contrato
    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int Speed)
        {
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"La Sirena Nada a {Speed}km/h";
        }

        public void animalSound()
        {
            Console.WriteLine("Sonido del pez");
        }
    }

    // Se puede implementar multiples intefaces realizando la separacion por medio de una coma
    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"{Name} Nada {Speed} km/h";
        }

        public void animalSound()
        {
            Console.WriteLine("Sonido del pez");
        }
    }

    public interface IAnimal
    {
        // Propiedad de la interfaz
        public string Name { get; set; }
    }

    // La interfaz solo puede contener métodos y propiedades con cuerpos vacíos.
    public interface IFish
    {
        // Propiedades de la interfaz
        public int Speed { get; set; }
        
        // Metodos de la interfaz
        public string Swim();
        public void animalSound();
    }
}