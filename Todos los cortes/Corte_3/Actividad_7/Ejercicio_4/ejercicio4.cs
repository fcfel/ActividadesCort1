using System;
using System.Collections;
namespace Ejercicio_4
{
     /*
      Escriba un programa que dadas dos lista/pila/colaordenadas de números enteros, realicelaconcatenaciónenformaordenadadeambas lista/pila/cola.
      */
      // Grupo: 239-2A DIA
      // Turno: Diurno
    class ejercicio4
    {
        
        
           Queue Cl1 = new Queue();
           Queue Cl2 = new Queue();

        int unión, unión2, c, z;

          public void Proceso()
         {
            Console.WriteLine("Digite el limite de numeros de la primera cola");
            unión = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int n = 0; n < unión; n++)
            {
                Console.WriteLine();
                Console.WriteLine($"Digite valor {n + 1} de la cola 1");
                c = int.Parse(Console.ReadLine());
                Cl1.Enqueue(c);
            }
            Console.WriteLine();
            Console.WriteLine("Digite el limite de numeros de la segunda cola");
            unión2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int v = 0; v < unión2; v++)
            {
                Console.WriteLine();
                Console.WriteLine($"Digite el valor {v + 1} de la cola 2");
                z = int.Parse(Console.ReadLine());
                Cl2.Enqueue(z);
            }

            Console.WriteLine("Presione Enter para poder continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Primera cola tiene como valores:");
            foreach (int r in Cl1)
            {
                Console.Write(r + " ");

            }
            Console.WriteLine("\n");
            Console.WriteLine("Segunda cola tiene como valores:");
            foreach (int r in Cl2)
            {
                Console.Write(r + " ");

            }
            Console.WriteLine("\n");

            Console.WriteLine("La unión de las colas es: ");
            ArrayList conversion = new ArrayList(Cl1);
            ArrayList conversion2 = new ArrayList(Cl2);
            conversion.AddRange(conversion2);
            Queue cola3 = new Queue(conversion);
            foreach (int v in cola3)
            {
                Console.WriteLine("-" + v);
            }
            Console.WriteLine("\n");
         }
         static void Main(string[] args)
         {
            ejercicio4 agregar = new ejercicio4();
            agregar.Proceso();
            Console.WriteLine("Fin del programa, Gracias");
            Console.ReadKey();
            Console.Clear();
         
        }
    }
}