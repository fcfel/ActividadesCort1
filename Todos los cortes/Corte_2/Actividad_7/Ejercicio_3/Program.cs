using System;
using System.Collections;

namespace Ejercicio_3
{
    class Program
    {
        unsafe static int * devolverApuntador(Queue listaEnteros,int * direccion)
        {
            
            int * puntero;
            foreach (int num in listaEnteros)
            {
                if (num==*direccion)
                {
                    puntero=&num;
                    return puntero;
                }
            }
            return null;
            
        }

        static void Main(string[] args)
        {
            bool salir=false;
            Queue listaEnteros=new Queue();

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
                    listaEnteros.Enqueue(num);
                }
                
            }
            unsafe
            {
                int primerNumero = (int) listaEnteros.Peek();
                int * puntero=devolverApuntador(listaEnteros,&primerNumero);

                Console.Write(*puntero);
                Console.Write(" Es el primer elemento de la cola");
                
            }
            

        }
    }
}
