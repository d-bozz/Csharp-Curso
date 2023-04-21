using System;

namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creo un objeto beer
                Beer beer = new Beer()
                {
                    Name = "London Porter",
                    Brand = "Fuller's"
                };

                Console.WriteLine(beer);
            }
            // Arrojo una excepcion personalizada
            catch(InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Arrojo una excepcion generica
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Creo mi excepcion personalizada que hereda de exception
        public class InvalidBeerException : Exception
        {
            public InvalidBeerException() : 
                base("La cerveza no tiene nombre o marca, por lo cual es invalida")
            {
              
            }
        }

        // Creo una clase cerveza
        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            public override string ToString()
            {
                // En caso de error arrojo mi excepcion personalizada InvalidBeerException()
                if (Name == null || Brand == null)
                    throw new InvalidBeerException();

                return $"Cerveza: {Name}, Brand: {Brand}";
            }
        }
    }
}
