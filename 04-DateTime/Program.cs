using System;
using System.Diagnostics.Tracing;
using static System.Net.Mime.MediaTypeNames;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# incluye DateTimeestructura para trabajar con fechas y horas.

            DateTime dt1 = new DateTime(); // Asigna por default el valor 01/01/0001 00:00:00

            DateTime dt2 = new DateTime(2022, 12, 31); // Se asigna manualmente año, mes y dia

            DateTime dt3 = new DateTime(2022, 12, 31, 5, 10, 20); // Se asigna manualmente año, mes, dia, hora, minutos, segundos

            DateTime currentDateTime = DateTime.Now;  // devuelve fecha y hora actuales

            DateTime todaysDate = DateTime.Today; // Regresa la fecha actual

            DateTime currentDateTimeUTC = DateTime.UtcNow;// Regresa la fecha y hora actual formato UTC

            DateTime tomorrowDate = DateTime.Today.AddDays(1); // Obtener el dia de mañana

            DateTime yesterdayDate = DateTime.Today.AddDays(-1); // Obtener el dia de ayer

            DateTime nextMonthDate = DateTime.Today.AddMonths(1); // Obtener el mes siguiente

            int days = DateTime.DaysInMonth(2014, 9); // Obtener dias del mes de Setiembre

            // Obtener dias de diferencia entre dos fechas:
            string value1 = "3/12/2020";
            string value2 = "3/14/2020";

            // Parse the dates.
            var date1 = DateTime.Parse(value1);
            var date2 = DateTime.Parse(value2);

            // Compute the difference between the 2 dates.
            var difference = date2.Subtract(date1);
            Console.WriteLine("DAYS DIFFERENCE: {0}", difference.TotalDays);
        }
    }
}