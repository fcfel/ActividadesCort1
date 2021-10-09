using System;
using System.Collections;

namespace PUNTO_5
{
    class PUNTO_5
    {
        static void Imprimirpil(ArrayList pil0)
        {
            foreach (int V in pil0)
            {
                Console.WriteLine($"- {V}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void ImprimirNuPil(ArrayList Vpil)
        {
            foreach (int V in Vpil)
            {
                Console.WriteLine($"- {V}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void Main(string[] args)
        {
            String WhileLoop = "";
            do
            {

                int mun = 0, CANT = 0;

                ArrayList pil = new ArrayList();
                ArrayList NuPil = new ArrayList();

                Console.WriteLine("PUNTO NUMERO 5 ");
                Console.WriteLine("Crear una Pila P con numeros enteros y despues pasarlos a una nueva pila");
                Console.WriteLine("----------------------------------------------------------------------------\n");

                Console.WriteLine("¿Cuantos datos desea ingresar para Pila P?");
                CANT = int.Parse(Console.ReadLine());

                for (int N = 0; N < CANT; N++)
                {
                    Console.Write("- ");
                    mun = int.Parse(Console.ReadLine());
                    pil.Add(mun);
                }

                Console.WriteLine("Los valores ingresados a Pila P son: ");

                Imprimirpil(pil);

                Console.WriteLine("Los valores de la Pila P seran transpasado a una nueva Pila ");

                foreach (int s in pil)
                {
                    NuPil.Add(s);
                }

                Console.WriteLine($"nueva Pila tiene {NuPil.Count} datos y estos son sus valores ");
                ImprimirNuPil(NuPil);

                pil.Clear();
                Console.WriteLine($"Pila P quedo con {pil.Count} datos");

                Console.WriteLine("-----------------------------");
                Console.WriteLine("¿Desea Repetir el programa? (S/N)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("-----------------------------");

            } while (WhileLoop == "s" || WhileLoop == "S");
            Console.WriteLine("Fin del programa,gracias");

        }
    }
}

