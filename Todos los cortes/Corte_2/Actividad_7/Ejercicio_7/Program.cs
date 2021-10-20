using System;
using System.Collections.Generic;

namespace Cola_4
{
    
    class Program
    {
         /* Escriba una rutina que reciba dos Pilas P1 y P2 de números flotantes y apile las mismas 
en una nueva Pila resultante. Es de destacar que las Pilas recibidas no deben sufrir ningún
tipo de cambio o alteración.

         */
        
        static void Main(string[] args)
        {
            float a=0.0f;
            int num;
            Queue <float> Cola1 = new Queue<float>();
            //Cola.Enqueue("1");
            System.Console.WriteLine("Cuantos datos desea ingresar");
            num=int.Parse(Console.ReadLine());

           
            for(int i =0;i<num;i++){
                 System.Console.WriteLine($"ingrese dato {i+1} a la Cola: ");
                 a=float.Parse(Console.ReadLine());

                 Cola1.Enqueue(a);
            }   

            System.Console.WriteLine("Los elementos ingresado son:");
            foreach (int b in Cola1)
                 { 
                  System.Console.WriteLine($" {b}  "); 
                 }  
            System.Console.WriteLine("_____________________________________________________________");



             Queue<float> Cola2 = new Queue<float>();
            //Cola.Enqueue("1");
            System.Console.WriteLine("Cuantos datos desea ingresar a la otra cola: ");
            num=int.Parse(Console.ReadLine());

           
            for(int i =0;i<num;i++){

                 System.Console.WriteLine($"ingrese dato {i+1} a la Cola: ");
                 a=float.Parse(Console.ReadLine());

                 Cola2.Enqueue(a);

                 
            } 
            
            System.Console.WriteLine("Los elementos ingresado son:");
            foreach (int b in Cola2)
                 { 
                  System.Console.WriteLine($" {b}  "); 
                 }  
            System.Console.WriteLine("_____________________________________________________________");

            System.Console.WriteLine("Total de elementos ingresados: ");

            System.Console.WriteLine();

                 foreach (int b in Cola1)
                 {
                      System.Console.WriteLine($"  {b}");
                     
                 }
                 
                  foreach ( int d in Cola2)
                      {
                          System.Console.WriteLine($"  {d} ");
                      }
        }
        
    }
}
