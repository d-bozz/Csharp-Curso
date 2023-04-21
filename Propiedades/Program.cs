using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
            Console.WriteLine(mySale.Date);
        }

        class Sale
        {
            //El significado de Encapsulación es asegurarse de que los datos "sensibles" estén ocultos para los usuarios. 
            //   * Declarar campos/variables como private
            //   * Proporcionar métodos public get y set, a través de propiedades, para acceder y actualizar el valor de un campo private.

            // Fields
            private int total;
            private DateTime date;


            // Getter y setter
            public int Total { get; set; }
            public DateTime Date { get; set; }


            // Constructor
            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;
            }

            // Methods
            public void DateTime()
            {
                Console.WriteLine("La fecha es:" + date);
            }

        }
    }
}
