using System;
using System.Collections.Generic;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
            int numero, contadorPares=0, contadorImpares=0;
            List<int> listaPares = new List<int>();
            List<int> listaImpares = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("introducir un numero ");
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 ==0){
                contadorPares=contadorPares+1;
                listaPares.Add(numero);
                }
                else{
                contadorImpares=contadorImpares+1;
                listaImpares.Add(numero);
                }
                
            }

            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int i in listaPares)
            {
                sumaPares += i;
            }
            foreach (int i in listaImpares)
            {
                sumaImpares += i;
            }
         Console.WriteLine("Cantidad pares: "+ contadorPares+ " Cantidad impares:" +contadorImpares);
         Console.WriteLine("Suma pares: "+ sumaPares + " Suma impares:" + sumaImpares);
         Console.WriteLine("Promedio pares: "+ sumaPares/listaPares.Count + " Promedio impares:" + sumaImpares/listaImpares.Count);
         Console.ReadKey();
        }
    }
}