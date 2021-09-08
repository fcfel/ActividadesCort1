using System;

namespace PUNTO_9
{
    class Program
    {
        static void Main(string[] args)
         {
            //trabajo realizado por: Felipe Cruz, Jeison Sastoque, Jesus De La Cruz, Wilson Gamba
            int x, y, z;
            string desea="";
            do
            {
           
            Console.WriteLine("Ingrese el primer lado");
            x=int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado");
            y=int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado");
            z=int.Parse(System.Console.ReadLine());

            if (x==y && y==z)
            {
                System.Console.WriteLine("El triangulo es Equilatero");
            }
            else 
            {
                if (x==y || x==z || y==z)
                {
                    System.Console.WriteLine("El triangulo es Isoceles");
                }
            
            else
            {
                if (x!=y && x!=z && z!=y)
                {
                    System.Console.WriteLine("El trianagulo es Escaleno");
                }
            }
            }
            System.Console.WriteLine("¿Desea repetir s/n?");
            desea=Console.ReadLine();
            } while (desea=="s");
        }
    }
}