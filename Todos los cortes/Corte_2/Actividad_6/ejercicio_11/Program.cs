using System;
using System.Collections;
namespace proyecto_final
{
    class Ejercicio_11

        /* Problema 11: Escriba una rutina que reciba una Pila P de números flotantes y devuelva una Cola, manteniendo el orden de salida de los elementos.  */

    {
        ArrayList flotante = new ArrayList();
        int numeros;
        float ele;
        public void lista ()
        {
            Console.WriteLine();
            Console.WriteLine ("Ingrese la cantidad de numeros  que quiere ingresar a la lista: ");
            numeros= int.Parse (Console.ReadLine());
         
            for (int a=0; a<numeros; a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el elemento numero {a+1} de la lista: ");
                Console.WriteLine();
                ele= float.Parse (Console.ReadLine());
                flotante.Add (ele);
            }
            Console.WriteLine();
            Console.WriteLine("La lista de flotantes es: ");
            Console.WriteLine();
            foreach (float a in flotante)
            {
           
                Console.Write (a+" ");
            }
            Console.WriteLine ("\n");
            

        }
        static void Main(string[] args)
        {
        

        Ejercicio_11 list = new Ejercicio_11();
        string opciones;
      
        do
        {
        Console.WriteLine ("───────────────────");  
        list.lista();
        Console.WriteLine ("───────────────────");  
        Console.WriteLine ("¿Deseas añadir mas numeros a la lista? (S/N)");
        opciones= Console.ReadLine();
        }while (opciones!="n" && opciones!="N");
        Console.WriteLine ("Fin del programa (Fin del programa, presione INTRO para continuar)");
        Console.ReadKey();
        Console.Clear();

        }
    }
}