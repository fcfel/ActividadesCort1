using System;
using System.Collections;
namespace proyecto_final
{
    class Ejercicio_10
    {

        /* 10. Escriba una rutina que reciba una Pila P de números flotantes y devuelva una nueva Pila,
pero con los elementos invertidos, es decir el último de la Pila P, pasará a ser el primero
de la nueva Pila Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o
alteración.
*/

/* Creado por: JESUS DE LA CRUZ MERCADO
Grupo: JEISON SASTOQUE - CAMILO GAMBA - FELIPE CRUZ
*/
        ArrayList flotante = new ArrayList();
        int numeros;
        float ele;
        public void lista ()
        {
            Console.WriteLine();
            Console.WriteLine ("Ingrese la cantidad de numeros que quiera en la lista: ");
            numeros= int.Parse (Console.ReadLine());
         
            for (int a=0; a<numeros; a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el elemento  del numero {a+1} de la lista: ");
                Console.WriteLine();
                ele= float.Parse (Console.ReadLine());
                flotante.Add (ele);
            }
            ArrayList copia = new ArrayList();

            copia.AddRange(flotante);

            copia.Reverse();

             Console.WriteLine();

            Console.WriteLine("La lista invertida es: ");

            Console.WriteLine();

            foreach (float a in copia)
            {
           
                Console.Write (a+" ");
            }
            Console.WriteLine ("\n");
            

        }
        static void Main(string[] args)
        {

        Ejercicio_10 list = new Ejercicio_10();
        string opciones;
      
        do
        {
        Console.WriteLine ("───────────────────");  

        list.lista();

        Console.WriteLine ("───────────────────");  

        Console.WriteLine ("¿Deseas añadir  mas numeros a la lista? (S/N)");

        opciones= Console.ReadLine();

        }while (opciones!="n" && opciones!="N");

        Console.WriteLine ("Fin del programa (presione INTRO para continuar)");

        Console.ReadKey();

        Console.Clear();

        }
        
    }
}