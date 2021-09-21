using System;

namespace PUNTO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese un número");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write(i + ". "+ num + " ");
                for (int j = 0; j < num; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
    }
 } 
 }
