using System;

namespace PUNTO_10
{
    class Program
    {
        static void Main(string[] args)
        {
        
          int a,b,c,vacunas=1000;
         System.Console.WriteLine("Programa que determina ver cuantas vacunas se han entregado");
          Console.WriteLine (" ");
        
         do
         {

         Console.WriteLine ("¿Cuantas vacunas entrego al punto A?: ");
         a= int.Parse (Console.ReadLine());
         vacunas= vacunas-a;
         Console.WriteLine ("¿Cuantas vacunas entrego al punto B?: ");
         b= int.Parse (Console.ReadLine());
         vacunas= vacunas-b;
         Console.WriteLine ("¿Cuantas vacunas entrego al punto C?: ");
         c= int.Parse (Console.ReadLine());
         vacunas= vacunas-c;
         }while (vacunas>200);
        
         Console.WriteLine ("El inventario de vacunas ya es menor a 200 ");
         
         Console.WriteLine ("La cantidad de vacunas entregadas en el punto A fueron de "+a);
         Console.WriteLine ("La cantidad de vacunas entregadas en el punto B fueron de "+b);
         Console.WriteLine ("La cantidad de vacunas entregadas en el punto C fueron de "+c);

        }
    }
}