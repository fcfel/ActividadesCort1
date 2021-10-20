using System;
using System.Collections;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir=false;
            Queue listaEnteros = new Queue();

            while (salir==false){
                Console.WriteLine("Digite un numero entero, para salir del programa digite el numero 0");
                int num=int.Parse(Console.ReadLine());
                if(num==0)
                {
                    salir=true;
                }
                else
                {
                    listaEnteros.Enqueue(num);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Los valores de la cola son: ");
            foreach (int num in listaEnteros)
            {
                Console.WriteLine(num);
            }
        
        }
    }
}
