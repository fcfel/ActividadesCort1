using System;

namespace ACTIVIDAD_4
{
    
    class program
    {
        static void Main(string [] args)
        {

            int y = 0; z = 0;
            int [] n;

            Console.write("Ingresa los 10 numeros a organizar");

            y = int.parse(Console.ReadLine());

            n = new int[x];

            for(int x = 0; x < y; x++)
            {
                Console.writeLine("\nIngrese el numero {0}", x + 1);

                n[x] = int.parse(Console.ReadLine());
            }
            for(int i = 1; i < tp; i++)
            {
                for(int p = 0; p < tp - 1; p++)
                {
                    if (n[i] < n[p])
                    {
                        z = n[i];
                        n[i] = n[p];
                        n[p] = z
                    }
                }
            }

            Console.writeLine(De menor a mayor);

            for(int q = 0; q < y; q++)
            {
                Console.write(n[q] + " - ");
            }

            Console.writeLine();
            Array.Reverse(n);

            Console.writeLine("\nDe Mayor a Menor");
            for(int y = 0; y < n.Length; y++)
            {
                Console.write(n[y].Tostring() + " - ");
            }
            Console.ReadKey();
        }
    }
    
}