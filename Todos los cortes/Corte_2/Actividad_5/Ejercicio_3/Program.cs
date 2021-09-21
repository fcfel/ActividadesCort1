using System;

namespace EjercicioMatricesBi3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] num = new int [,] { {56,75,78,12,10,28}, {61,49,75,71,42,15}, {35,48,56,55,24,81}};
            Console.WriteLine();
            Console.WriteLine("--- Impresión de matriz ---");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(num[i,j]+ "    ");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
