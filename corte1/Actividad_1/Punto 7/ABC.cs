using System;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string teclado = "";
            int A=0;
            int B=0;
            int C=0;
            int total;
            total= A+B+C;
            Console.WriteLine("Ingrese el valor del producto A");
            teclado=Console.ReadLine();
            A=Convert.ToInt32(teclado);

            Console.WriteLine("Ingrese el valor del producto B");
            teclado=Console.ReadLine();
            B=Convert.ToInt32(teclado);

            Console.WriteLine("Ingrese el valor del producto C");
            teclado=Console.ReadLine();
            C=Convert.ToInt32(teclado);

            // if para las posibles salidas

            if (A>B && A>C)
            {
                System.Console.WriteLine("Las ventas de A son las más elvadas"+A);
            }
                if (A<200 && B<200 && C<200)
                {
                   System.Console.WriteLine("Ningun producto tiene unas ventas inferiores a 200"+ A, B, C); 
                } 
                
                if (A>400 && B>400 && C>400)
                {
                   System.Console.WriteLine("Algun producto tiene ventas superiores de 400 "+A); 
                }

                if (A>=500 && B>=500 && C>=500)
                {
                   System.Console.WriteLine("La media de ventas es superior a 500 ",A,B,C);
                }
                if (B<A && B<C)
                {
                    System.Console.WriteLine("El producto B no es el mas vendido "+B);
                }

                else
                {
                    System.Console.WriteLine("Las ventas deben estar entre 500 y 100"+total);
                }
            

        }
    }
}
