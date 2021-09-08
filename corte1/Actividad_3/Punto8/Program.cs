using System;

namespace PUNTO_8
{
    class Program
    {
        static void Main(string[] args)
        {
             float a=0.0f;
            float b=0.0f;
            float c=0.0f;
            float x1=0.0f;
            float x2=0.0f;
            string desea="";
            do
            {
                System.Console.WriteLine("Programa para realiza una ecuacion de segundo grado");
                System.Console.WriteLine("");
           
            Console.WriteLine("Digite el valor de a");
            a=int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite el valor de b");
            b=int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite el valor de c");
            c=int.Parse(System.Console.ReadLine());

            x1= (float)((-b-Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a));
            x2= (float)((-b+Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a));

            System.Console.WriteLine("El resultado es: "+x1);
            System.Console.WriteLine("El resultado es: "+x2);
            System.Console.WriteLine("");
            System.Console.WriteLine("Desea continuar S/N");
            desea=Console.ReadLine();

             } while (desea=="S");
            
        }
    }
}