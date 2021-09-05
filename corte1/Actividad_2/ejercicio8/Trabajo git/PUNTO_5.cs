using System;

namespace ACTIVIDAD_5

{
    class Program
    {
        static void Main(string[] args)
        {
            string R = "";
            R = CalculadoraFecha(Convert.ToDateTime("13-04-1980"), Convert.ToDateTime("25-08-2009"));

            Console.WriteLine(R);
            Console.ReadKey();
        }
        
        static string CalculadoraEdad(DateTime Fecha, DateTime FechaLimite)
        {
            int Year = Fecha.Year;
            int month = Fecha.Month;
            int day = Fecha.Day;

            int año_bisiesto = 0;

            for (int i = Year; i < FechaLimite.Year; i++)
            {
               if (DateTime.IsLeapYear(i))
                {
                    ++año_bisiesto;

                }
            }

            TimeSpan timeSpan = FechaLimite.Subtract(Fecha);
            day = timeSpan.Days - año_bisiesto;
            int r = 0;

            Year = Math.DivRem(day, 365, out r);
            month = Math.DivRem(r, 30, out r);
            day = r;


            return "La fecha que ha pasado entre las dos son en:" + Year + "Años" + month + "Meses y" + day + "dias.";
                 
        }
    }
}