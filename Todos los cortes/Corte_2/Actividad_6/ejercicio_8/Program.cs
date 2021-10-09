using System;
using System.Collections;

namespace ejercicio_8
{

    /* 8. Escriba una rutina que reciba dos Pilas P1 y P2 de números flotantes y apile las mismas 
en una nueva Pila resultante. Es de destacar que las Pilas recibidas no deben sufrir ningún
tipo de cambio o alteración.

Creado por: FELIPE CRUZ 
Grupo: Jeison Sastoque- Camilo Gamba- Jesus de la Cruz 

    */
    
    class Punto_8
    {
        ArrayList p1 =new ArrayList ();
        ArrayList p2 =new ArrayList ();

        int pil_1;
        int pil_2;
        int num;

    public void Pila1()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Ingrese la cantidad de numeros que desee en la Pila 1: ");
        num =int.Parse(Console.ReadLine());

        for (int i = 0; i <num; i++)
        {
            System.Console.WriteLine($"Ingrese el elemento de numero {i+1} de la lista:");
            System.Console.WriteLine();
            pil_1= int.Parse(Console.ReadLine());
            p1.Add (pil_1);
            
        }
       
        }
        // 
         public void Pila2()
        {
            System.Console.WriteLine();
        System.Console.WriteLine("Ingrese la cantidad de numeros que desee en la Pila 2: ");
        num =int.Parse(Console.ReadLine());

        for (int i = 0; i <num; i++)
        {
            System.Console.WriteLine($"Ingrese el elemento de numero {i+1} de la lista:");
            System.Console.WriteLine();
            pil_2= int.Parse(Console.ReadLine());
            p2.Add(pil_2);
            
        }

        

        ArrayList pila3 = new ArrayList();

        pila3.AddRange(p2);

        System.Console.WriteLine("la pila 1 con valores de la pila 2");

        foreach (int a in pila3)
        {
            System.Console.WriteLine(a+"");
        }
        System.Console.WriteLine("\n");

        ArrayList pila4 =new ArrayList();
        pila4.AddRange(p1);
        System.Console.WriteLine("La pila 2 con valores de la pila 1");

        foreach (int b in pila4)
        {
            System.Console.WriteLine(b);
        }
        System.Console.WriteLine("\n");

    }
      
        static void Main(string[] args)
        {
            Punto_8 list =new Punto_8();
            
            string opc;

            do
            {
                System.Console.WriteLine("───────────────────");
                list.Pila1();
                list.Pila2();
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

