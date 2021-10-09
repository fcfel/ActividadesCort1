using System;
using System.Collections;

namespace ejercicio_9
{
    /*
    9.Escriba una rutina que reciba una Pila P de números enteros y devuelva una copia exacta
de la misma. Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o alteración.

Creado por: FELIPE CRUZ
GRUPO: Jeison Sastoque-Camilo Gamba- Jesus de la Cruz
    */
    class Punto_9
    {
        ArrayList p1 = new ArrayList();
        int num1;
        int pil1;


        public void Pila ()
        {
            System.Console.WriteLine("Ingrese la cantidad de numeros que quiera en la lista:");
            num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                System.Console.WriteLine($"Ingrese el elemento {i+1} de la lista: ");
                 pil1=int.Parse(Console.ReadLine());
                 p1.Add(pil1);
            }

            ArrayList copia=new ArrayList();
            copia.AddRange(p1);
            System.Console.WriteLine("La copia es: ");
            foreach(int a in copia){
                System.Console.WriteLine(a);
            }

        }
        static void Main(string[] args)
        {
            Punto_9 lista =new Punto_9();
            string opc;
            do
            {
                lista.Pila();
            System.Console.WriteLine("Deseas repetir el programa? S/N");
            opc=Console.ReadLine();
                
            } while (opc!="n" && opc!="N");

            System.Console.WriteLine("Fin del programa");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
