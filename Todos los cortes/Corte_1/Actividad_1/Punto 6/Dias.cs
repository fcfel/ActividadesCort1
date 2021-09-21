using System;

namespace Punto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de variables 

            int segundos, minutos, horas, dias;
            string teclado ="";

            System.Console.WriteLine("Escriba la cantida de segundos ");
            teclado=Console.ReadLine(); //leer dato
            segundos=Convert.ToInt32(teclado); //almacenar dato

            // determinar a cuanto vale dias,hora,minutos y segundos 

            dias = segundos / (24 * 60* 60);
            segundos = segundos % (24 * 60* 60);
            horas = segundos / (60 * 60);
            segundos = segundos % (60*60);
            minutos = segundos / (60);
            segundos = segundos % (60);

            //salida

            System.Console.WriteLine("El numero que ingreso equivale a {0} dias, {1} horas, {2} minutos , {3} segundos ",dias,horas,minutos,segundos);
        }
    }
}
