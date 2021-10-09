using System;
using System.Collections;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir=false;
            ArrayList listaEnteros=new ArrayList();

            while (salir==false){
                Console.WriteLine("Digite un numero entero, para salir del programa digite el numero 0");
                int num=int.Parse(Console.ReadLine());
                if(num==0)
                {
                    salir=true;
                }
                else
                {
                    listaEnteros.Add(num);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Los valores de la lista son: ");
            foreach (int num in listaEnteros)
            {
                Console.WriteLine(num);
            }
        
        }
    }
}
