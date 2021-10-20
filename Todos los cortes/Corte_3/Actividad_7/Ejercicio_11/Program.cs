using System;
using System.Collections;

namespace Ejercicio_11
{
    class Programa_11
    {
        int Cantidad = 0;
        float Valor = 0f;

        Queue ColaP = new Queue();
        ArrayList List1 = new ArrayList();
        Queue ColaNueva = new Queue();

        public void Llenar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros flotantes que va a ingresar para llenar la cola");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los numeros flotantes");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write("- ");
                Valor = float.Parse(Console.ReadLine());
                ColaP.Enqueue(Valor);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Los numeros de la cola P son estos y hay {ColaP.Count} elementos");
            foreach(float i in ColaP)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public void Transpaso()
        {
            foreach(float a in ColaP)
            {
                List1.Add(a);
            }

            foreach (float n in List1)
            {
                ColaNueva.Enqueue(n);
            }
        }

        public void ImprimirNueva()
        {
            Console.WriteLine($"Los numeros de la Nueva Cola son estos y hay {ColaNueva.Count} elementos");
            foreach (float i in ColaNueva)
            {
                Console.WriteLine($"- {i}");
            }
        }

        static void Main(string[] args)
        {
            string WhileLoop = "";
            do
            {
                Console.WriteLine("Problema#11");
                Console.WriteLine("Este programa imprime los nuemros flotantes que hay en la cola P");
                Console.WriteLine("----------------------------------------------------------------------------");

                Programa_11 pv = new Programa_11();
                pv.Llenar();
                Console.WriteLine("---------------------------------");
                pv.Imprimir();
                Console.WriteLine("---------------------------------");
                pv.Transpaso();
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