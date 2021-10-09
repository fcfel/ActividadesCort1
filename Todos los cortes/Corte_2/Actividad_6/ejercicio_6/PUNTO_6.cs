using System;
using System.Collections;

namespace PUNTO_6
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            ArrayList pil = new ArrayList();
            Random NumAlios = new Random();

            int Cant;

            Console.WriteLine("Ingrese la cantidad de la lista");
            Cant = int.Parse(Console.ReadLine());

            for (int n = 0; n < Cant; n++)
            {
                pil.Add(NumAlios.Next(0,100));
            }

            pil.Sort();

            Console.WriteLine("Contenido actual de la Pila1");
            foreach (int v in pil)
            {
                Console.WriteLine($" [{v}] ");
            }

            ArrayList pILA = new ArrayList();

            Console.WriteLine("Se pasan los elementos a la nueva lista. Además, se invirtieron los datos para la Pila2");

            pILA.AddRange(pil);
            pILA.Reverse();

            Console.WriteLine("Contenido actual de la Pila2");
            foreach (int k in pILA)
            {
                Console.WriteLine($" [{k}] ");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los elementos de la Pila1");
            Console.WriteLine("RECUERDE! AL ELIMINAR LOS ELEMENTOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA LISTA");
            int Res = 0;
            Res = int.Parse(Console.ReadLine());

            if (Res == 1)
            {
                pil.Clear();

                Console.WriteLine("");
                
                foreach (int l in pil)
                {
                    Console.WriteLine($" [{l}] ");
                }

                Console.WriteLine("SE ELIMINARON TODOS LOS ELEMENTOS DE ESTA LISTA");
            }

            else
            {
                Console.WriteLine("Decidio no eliminar los elementos de la Pila1");
            }
        }
    }
}

