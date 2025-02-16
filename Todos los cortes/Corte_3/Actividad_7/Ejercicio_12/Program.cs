﻿using System;
using System.Collections;

namespace Ejercicio_12
{
    class Programa_12
    {
        int Cantidad = 0;
        int Valor = 0;

        Queue ColaC = new Queue();
        ArrayList List1 = new ArrayList();
        Queue ColaNueva = new Queue();

        public void Llenar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar para llenar la cola C");
            Cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write("- ");
                Valor = int.Parse(Console.ReadLine());
                ColaC.Enqueue(Valor);
            }
        }

        public void ImprimirP()
        {
            Console.WriteLine($"La Cola C tiene estos valores y son {ColaC.Count} elementos");
            foreach (int i in ColaC)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public void Mover()
        {
            foreach (int h in ColaC)
            {
                List1.Add(h);
            }

            foreach (int r in List1)
            {
                ColaNueva.Enqueue(r);
            }

            ColaC.Clear();
        }

        public void ImprimirNueva()
        {
            Console.WriteLine($"Los numeros de la nueva cola son estos y son {ColaNueva.Count} elementos");
            foreach (int x in ColaNueva)
            {
                Console.WriteLine($"- {x}");
            }

            Console.WriteLine($"La Cola C quedo con {ColaC.Count} elementos");
        }


        static void Main(string[] args)
        {
            string WhileLoop = "";
            do
            {
                Console.WriteLine("Problema#12");
                Console.WriteLine("Este programa guarda los datos en un Cola C y se pasa a una nueva Cola y la Cola C queda vacia");
                Console.WriteLine("----------------------------------------------------------------------------");

                Programa_12 pv = new Programa_12();
                pv.Llenar();
                Console.WriteLine("---------------------------------");
                pv.ImprimirP();
                pv.Mover();
                Console.WriteLine("---------------------------------");
                pv.ImprimirNueva();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("---------------------------------");
            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
