using System;
//trabajo realizado por: Felipe Cruz, Jeison Sastoque, Jesus De La Cruz, Wilson Gamba
namespace PUNTO_4
{
    class Program
    {
        static void Main(string[] args)
        {
             float n ;
             float i=0;
             float p=0;
             Console.Write("Ingrese un numero: ");
             n = float.Parse(System.Console.ReadLine());
             for (i=1;i<=n;){
             i++;
             }
             p= 1/i+n;
             Console.Write("El reusultado es: "+p);   
        }
    }
}