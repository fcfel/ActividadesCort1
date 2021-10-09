using System;
using System.Collections;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir=false;
            ArrayList listaEnteros=new ArrayList();

            while (salir==false)
            {
                Console.WriteLine("Digite un numero entero, Para dejar de llenar la lista ingrese el numero 0 ");
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
            int suma=0;
            foreach (int num in listaEnteros)
            {
                suma+=num*num;
                //Math.Pow(num,2) elevar un numero
                
            }
            Console.WriteLine();
            Console.WriteLine("Los valores de la lista son: ");
            foreach (int num in listaEnteros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("La sumatoria de los cuadrados de los elementos de la lista es: "+suma);
        }
    }
}
