using System;
using System.Collections.Generic;

namespace Ejercicio_8
{

    class Program
    {
        /*
        Escriba una rutina que reciba dos Pilas P1 y P2 de números enteros y proceda a
   intercambiar sus elementos, pero manteniendo el orden de salida de los elementos. Al
   finalizar la rutina, la Pila P1 tendrá los elementos de la Pila P2 y esta a su vez tendrá los 
   elementos de la Pila P1.*/
        static void Main(string[] args)
        {
            int a = 0;
            int num;
            Queue<int> Cola1 = new Queue<int>();
            //Cola.Enqueue("1");
            System.Console.WriteLine("Cuantos datos desea ingresar");
            num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                System.Console.WriteLine($"ingrese dato {i + 1} a la Cola: ");
                a = int.Parse(Console.ReadLine());

                Cola1.Enqueue(a);
            }

            System.Console.WriteLine("Los elementos ingresado son:");
            foreach (int b in Cola1)
            {
                System.Console.WriteLine($" {b}  ");
            }
            System.Console.WriteLine("_____________________________________________________________");

            System.Console.WriteLine("La Copia de la Cola es: ");
            foreach (int b in Cola1)
            {
                System.Console.Write($" {b}  ");
            }
            
        }

    }
}