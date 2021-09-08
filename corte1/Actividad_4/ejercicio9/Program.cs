using System;

namespace PUNTO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int  repeat =0;
            int Numbers=0;
            Random bets = new Random();

            Console.WriteLine("Digita tus 5 numeros de la lóteria: ");
            do
            {    
                for(int i =1; i < 6; i++)
                {
                    Console.WriteLine($"Digita tu numero "+ i+" de la lóteria: ");
                    Numbers = int.Parse(Console.ReadLine());
                }
                if(Numbers <-1)
                {
                    Console.WriteLine("El numero no puede ser un negativo. Intente de nuevo: ");
                }
                Console.WriteLine($"Digita la serie de la lóteria: ");
                repeat = int.Parse(Console.ReadLine());
                if(repeat <=-1)
                {
                    Console.WriteLine("La serie no puede ser un negativa. Intente de nuevo: ");
                }
                else
                {
                    int[] gamblingvector  = new int[5];
                    gamblingvector [0] = bets.Next(1,100);
                    Console.WriteLine($"El numero de apuestas necesarias son: {gamblingvector[0]}");
                }
            }while(Numbers <=-1);
        }
    }
}
