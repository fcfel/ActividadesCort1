using System;
using System.Linq;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Punto_4
   
    {
        static void Main(string[] args)

        /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
        
        {
            int cont=1;
            int num1;

            List <int> Lista = new List<int>();

            while (cont<=10)
            {
                System.Console.WriteLine("ingrese valor "+cont);
                num1=int.Parse(Console.ReadLine());
                cont=cont+1;

            Lista.Add(num1);
            }

           Console.WriteLine("Desea organizarlos de forma ascendente 'A' o descendente 'D': ");
           char opc = char.Parse(Console.ReadLine());

           if(opc== 'A' || opc == 'a')
           {
               int [] A = Lista.ToArray();
               Array.Sort(A);
               foreach (int numero in A)
               {
                   Console.WriteLine(numero + " ");
               }
               
           }
           if(opc=='D'||opc == 'd')
           {
               int [] D = Lista.ToArray();
               D = D.OrderByDescending(numero=>numero).ToArray();
               foreach (int numero in D)
               {
                   Console.WriteLine(numero + " ");
               }

           }
            
        }
    }
}

    