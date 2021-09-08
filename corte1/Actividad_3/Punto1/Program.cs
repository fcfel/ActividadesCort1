using System;

namespace PUNTO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();        
            }
        }
    }
}
