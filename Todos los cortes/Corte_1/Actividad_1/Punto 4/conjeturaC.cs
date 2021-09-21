using System;

namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de varibles
            int n=0;
            string numero="";
            System.Console.WriteLine("ingrese un numero positivo");
            numero=Console.ReadLine(); //leer numero
            n=Convert.ToInt32(numero); // almacenar dato

            // estructura para determinar la conjetura 
            
            while (n !=1){ // while este ciclo repetitivo cierra cuando n = 1

            if(n%2==0){
            n = n /2;
            }
            else{
                n=3*n+1;
            }
            System.Console.WriteLine(""+n);
            }
        }
    }
}
