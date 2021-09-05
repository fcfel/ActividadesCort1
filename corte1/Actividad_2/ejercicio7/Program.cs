using System;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
            int j;
            char i;
            string oracion;
            int vocals = 0;
            int cons = 0;
            int num = 0;


            Console.WriteLine("programa para saber cuantas vocales, consonantes y simbolos hay en una oración");
            System.Console.WriteLine("");

            System.Console.WriteLine("Ingrese la frase u oración");
            oracion= Console.ReadLine();

            for (j = 0; j < oracion.Length; j++)

            {
                i=oracion[j];
                int c = char.ToLower(i);
                if ((c=='a')| (c=='e')| (c=='i')| (c=='o')| (c=='u') )
                {
                    vocals++;
                }

                else if ((c=='q')| (c=='w')| (c=='r')| (c=='t')| (c=='y')| (c=='p')| (c=='s')| 
                (c=='d')| (c=='f')| (c=='g')| (c=='h')| (c=='j')| (c=='k')| (c=='l')| (c=='ñ')| (c=='z')|
                (c=='x')| (c=='c')| (c=='v')| (c=='b')| (c=='n')| (c=='m'))
                {
                    cons++;
                }

                else if ((c=='1')| (c=='2')| (c=='3')| (c=='4')| (c=='5')| (c=='6')| (c=='7')| (c=='8')|
                 (c=='9')| (c=='0'))
                {
                    num++;
                }

                
            }
            System.Console.WriteLine("La oración tiene " + vocals + " vocales");
            System.Console.WriteLine("La oración tiene " + cons + " consonante");
            System.Console.WriteLine("La oración tiene " + num + " numeros");
            System.Console.WriteLine("La oración tiene " +  oracion.Length + " caracteres");
        }
    }
}
