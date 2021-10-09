using System;
using System.Collections;

namespace PUNTO_4
{
    class PUNTO_4
    {
        static void Main(string[] args)
        {
            ArrayList mun = new ArrayList();
            ArrayList mun0 = new ArrayList();
            ArrayList mun1 = new ArrayList();

            Console.WriteLine("PUNTO NUMERO 4 ");
            Console.WriteLine("----------------------------------------------------------------------------\n");
            
            Console.WriteLine("Indique numero conjunto 1");
            for (int cont = 0; cont < 5; cont++)
            {
                int num = int.Parse(Console.ReadLine());
                mun.Add(num);
                mun1.Add(num);
            }
            Console.WriteLine("Indique numero conjunto 2");
            for (int Contador = 0; Contador < 5; Contador++)
            {
                int num1 = int.Parse(Console.ReadLine());
                mun0.Add(num1);
                mun1.Add(num1);
            }
            Console.WriteLine("Sin concatenar:");
            foreach (int Valuar in mun1)
            {
                Console.Write(Valuar + " ");

            }
            Console.WriteLine("");

            mun1.Sort();
            Console.WriteLine("Concatenacion:\n");
            foreach (int value in mun1)
            {
                Console.Write(value + " ");
            }
        }
    }
}
