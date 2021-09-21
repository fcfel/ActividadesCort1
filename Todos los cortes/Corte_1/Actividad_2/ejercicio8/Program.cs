using System;

namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
            int num;
            string teclado="";
            Console.Write("Ingrese un numero del 1 al 12\n ");
            teclado=Console.ReadLine();
            num =Convert.ToInt32(teclado);

            switch (num)
            {
                case 1:
                System.Console.WriteLine("El mes es enero y tiene 31 dias");
                break;
                case 2:
                 System.Console.WriteLine("El mes es febrero y tiene 31 dias");
                break;
                case 3:
                 System.Console.WriteLine("El mes es marzo y tiene 31 dias");
                break;
                case 4:
                 System.Console.WriteLine("El mes es Abril y tiene 30 dias");
                break;
                case 5:
                 System.Console.WriteLine("El mes es Mayo y tiene 31 dias");
                break;
                case 6:
                 System.Console.WriteLine("El mes es Junio y tiene 30 dias");
                break;
                case 7:
                 System.Console.WriteLine("El mes es Julio y tiene 31 dias");
                break;
                case 8:
                 System.Console.WriteLine("El mes es Agosto y tiene 31 dias");
                break;
                case 9:
                 System.Console.WriteLine("El mes es Septiembre y tiene 30 dias");
                break;
                case 10:
                 System.Console.WriteLine("El mes es Octubre y tiene 31 dias");
                break;
                case 11:
                 System.Console.WriteLine("El mes es Noviembre y tiene 30 dias");
                break;
                case 12:
                 System.Console.WriteLine("El mes es Diciembre y tiene 31 dias");
                break;
                default: System.Console.WriteLine("No esta en el rango");
                break;
            }
        }
    }
}

