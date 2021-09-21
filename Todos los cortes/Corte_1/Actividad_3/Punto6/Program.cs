using System;
//trabajo realizado por: Felipe Cruz, Jeison Sastoque, Jesus De La Cruz, Wilson Gamba
namespace PUNTO_6
{
    class Program
    {
        static void Main(string[] args)
        {
               int Dig = 0;
               int Medidor=0;
               String Whileloop = "";

              Console. WriteLine("Bucle de numeros de 100 a 200" );

             do
             {
                Console. Write("Ingrese un numero entre 100 y 200: " );
                Dig = int.Parse(System.Console.ReadLine());

                if (Dig >=  100 && Dig <= 200)
                {
                    Console. WriteLine($"Usted ingreso el {Dig} la cadena es la siguiente" );
                    for (int m = Dig; m <= 200; m = m + 2)
                    {
                        Console. WriteLine($"- {m}" );
                        Medidor = Medidor + 1;
                    }
                    Console. WriteLine($"Hay un total de {Medidor} numeros pares" );
                }
                {
                    Console. WriteLine("El numero ingresado debe estar entre 100 y 200" );
                }
                Console. WriteLine("¿Desea salir del programa?" );
                Whileloop = System.Console.ReadLine();
                Medidor = 0;

            } while (Whileloop ==  "c"  | Whileloop ==  "C" );

        }
    }
}