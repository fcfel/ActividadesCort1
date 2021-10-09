using System;
using System.Collections;

namespace ejercicio_7
{

    /* 7. Escriba una rutina que reciba dos Pilas P1 y P2 de números flotantes y apile las mismas 
en una nueva Pila resultante. Es de destacar que las Pilas recibidas no deben sufrir ningún
tipo de cambio o alteración.

Creado por: FELIPE CRUZ 
Grupo: Jeison Sastoque- Camilo Gamba- Jesus de la Cruz 

    */
    
    class Punto_7
    {
        ArrayList n =new ArrayList ();

        float pil_1;
        float pil_2;
        int num;



    public void Pila ()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Ingrese la cantidad de numeros que desee en la Pila 1: ");
        num =int.Parse(Console.ReadLine());

        for (int i = 0; i <num; i++)
        {
            System.Console.WriteLine($"Ingrese el elemento de numero {i+1} de la lista:");
            System.Console.WriteLine();
            pil_1= float.Parse(Console.ReadLine());
            n.Add (pil_1);
            
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Ingrese la cantidad de numeros que desee en la Pila 2: ");
        num =int.Parse(Console.ReadLine());

        for (int i = 0; i <num; i++)
        {
            System.Console.WriteLine($"Ingrese el elemento de numero {i+1} de la lista:");
            System.Console.WriteLine();
            pil_2= float.Parse(Console.ReadLine());
            n.Add(pil_2);
            
        }

        ArrayList pila3 = new ArrayList();

        pila3.AddRange(n);

        System.Console.WriteLine("la pila resultante es: ");

        foreach (float a in pila3)
        {
            System.Console.WriteLine(a+ "");
        }
        System.Console.WriteLine("\n");

    }
    

      
        static void Main(string[] args)
        {
            Punto_7 list =new Punto_7();
            
            string opc;

            do
            {
                System.Console.WriteLine("───────────────────");
                list.Pila();
                System.Console.WriteLine("───────────────────");

                System.Console.WriteLine("¿Deseas repetir el proceso S/N ");
                opc=Console.ReadLine();
                
            } while (opc!="n" && opc!="N");
            
            System.Console.WriteLine("Fin del progrma \"INTRO\" para terminar ");
            Console.ReadKey();
            Console.Clear();

            
        }
    }
}
