using System;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es un comentario de una sola linea

            /* esto es un comentario
               que ocupa multiples lineas */
        }

        /// <summary>
        /// Esta es una funcion que devuelve si un color es verde o no
        /// </summary>
        /// <param name="color">Recibe un color</param>
        /// <returns>Devuelve verdadero si es verde de lo contrario falso</returns>
        public bool EsVerde(string color) 
        {
            bool bandera = false;
            if (color == "verde")
            { 
               bandera = true;
            }
            return bandera;
        }

    }
}