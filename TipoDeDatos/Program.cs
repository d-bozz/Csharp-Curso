using System;

namespace TipoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 3;            //De 0 a 255
            short myShort = 31;         //De -32.768 a 32.767
            int myInt = 12121;          //De -2.147.483.648 a 2.147.483.647
            long myLong = 128;          //De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            float myFloat = 5.75f;      //De ±1,5 x 10-45 a ±3,4 x 1038
            double myDouble = 12.1212d; //De ±5,0 × 10−324 a ±1,7 × 10308
            decimal myDecimal = 6.25m;  //De ±1,0 x 10-28 to ±7,9228 x 1028
            char myChar = 'A';          //Caracteres unicode
            bool myBoolean = false;     //True o False
            string myString = "cadena"; //Secuencia de caracteres


            int numeroInt = new int();
            Console.WriteLine(numeroInt); // Esto imprime 0

            int? numeroNull = null;
            Console.WriteLine(numeroNull); // Esto imprime un null

        }
    }
}
