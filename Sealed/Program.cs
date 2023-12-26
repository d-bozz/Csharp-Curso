using System;

namespace modificadorSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una sealed class o clase sellada es aquella de la cual no podemos heredar.
            // Lo que quiere decir que no podemos implementara en otras clases para tener acceso a sus miembros. 

            
        }
        class Vehiculo
        {
            //Código
        }

        sealed class Coche : Vehiculo
        {
            //Código
        }

        //// Esto da un error
        //class Furgoneta : Coche 
        //{ 
        //   //codigo
        //}


        // Modificador sealed en metodos
        class Vehiculo2
        {
            public decimal VelocidadMaxima { get; set; }
            public int NumeroRuedas { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }

            public Vehiculo2(string marca, string modelo)
            {
                Marca = marca;
                Modelo = modelo;
            }
            public virtual void Acelerar()
            {
                Console.WriteLine("Acelerar vehículo");
                //Pisar el acelerador
            }
        }

        class Moto : Vehiculo2
        {
            public int Cilindrada { get; set; }

            public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
            {
                Cilindrada = cilindrada;
            }

            public sealed override void Acelerar()
            {
                //Girar el puño
                Console.WriteLine("Acelerar Moto");
            }
        }
        class Triciclo : Moto
        {
            public Triciclo(string marca, string modelo, int cilindrada) : base(marca, modelo, cilindrada)
            {
            }

            //public override void Acelerar() //Error
            //{
                //Código
            //}
        }

    }
}