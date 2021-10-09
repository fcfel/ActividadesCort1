using System;
using System.Collections;

namespace Ejercicio_3
{
    class Program
    {
        unsafe static int * devolverApuntador(ArrayList listaEnteros,int * direccion)
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
            unsafe
            {
                int primerNumero= (int)listaEnteros[0];
                int * puntero=devolverApuntador(listaEnteros,&primerNumero);


                Console.Write(*puntero);
                Console.Write(" Es el primer elemto de la lista");
                
            }
            

        }
    }
}
