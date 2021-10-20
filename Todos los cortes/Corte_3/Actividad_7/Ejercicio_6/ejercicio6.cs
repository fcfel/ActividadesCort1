using System;
using System.Collections;
namespace Ejercicio_6
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P1: ");
            ArrayList Dtv = new ArrayList();
            Dtv.Add(1);
            Dtv.Add(3);
            Dtv.Add(5);

            imprime(Dtv);
            
            ArrayList datos2 = new ArrayList();
            Console.WriteLine("Ordenados:");
            
            datos2.AddRange(Dtv);  
            datos2.Reverse();
            imprime(datos2);

        static void imprime(ArrayList Arrays_Arre)
        {
            foreach (int v in Arrays_Arre)
            
            Console.Write(" {0}, ", v);
            Console.WriteLine("\n-------------");
        }
        }
    }
}
