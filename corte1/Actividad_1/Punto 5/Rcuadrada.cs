using System;

namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de variables 
            double numero;
            double raiz = 0;
            string valor = "";

            System.Console.WriteLine("Programa para determinar la raiz de un numero");
            System.Console.WriteLine("");

            //interaccion con el usuario 
            

            
            do
            {
             System.Console.WriteLine("ingrese un numero");
            valor = Console.ReadLine();
            numero = Convert.ToDouble(valor);
            
                // ciclo para validar si un numero es posiivo o negativo
            } while (numero<0);

            if(numero>=0){

            // operacion matematica realizada con Math Sqrt

            raiz=Math.Sqrt(numero);
            
            // salida 
            
            System.Console.WriteLine("La raiz de {0} es: {1} " , numero, raiz);

            }

        }
    }
}
