using System;
using System.Collections;

namespace Ejercicio_5
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            {
            Queue num1 = new Queue();
            Queue num2 = new Queue();
            requestNumbers(num1, 3);
            TransferQueueItems(num1, num2);
            Console.WriteLine($"La primera cola tiene {num1.Count} datos y la segunda tiene {num2.Count} datos");
            
        }
        static void requestNumbers(Queue NumerodeLista, int Cont)
        {
            Random VerNumer = new Random();
            for(int z = 0; z < Cont; z++)
            {
                NumerodeLista.Enqueue(VerNumer.Next(1,9));
            }
        }
        static void TransferQueueItems(Queue  Cadena, Queue NuevaCa)
        {
            foreach(var valor in Cadena)
            {
                NuevaCa.Enqueue(valor);
            }
            Cadena.Clear();
        }
        static void printQueueValues(Queue Cadena0)
        {
            foreach (var tema in Cadena0)
            {
                Console.WriteLine(tema);
            }
        }
        }
    }
}
