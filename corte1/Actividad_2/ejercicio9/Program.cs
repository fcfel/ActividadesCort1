
using System;

namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
              double area;
            double areat=0;
            double baset;
            double alturat;
            double radio;
            string teclado;
            double Pi=3.1416;
            System.Console.WriteLine("Digite (t) se desea saber el area de un triangulo o digite (c) si desea saber el area de un circulo");
            teclado=Console.ReadLine();

            if (teclado=="t")
            {
                System.Console.WriteLine("por favor digite la base del triangulo");
                baset=double.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Por favor digite la altura altura del triangulo");
                alturat=double.Parse(System.Console.ReadLine());

                areat=(baset*alturat)/2;
                System.Console.WriteLine("la base del triangulo es:"+areat);

            }

            else if (teclado=="c")
            {
                System.Console.WriteLine("Por favor ingrese el radio del circulo");
                radio=double.Parse(System.Console.ReadLine());

                area=(Pi*radio*radio);
                System.Console.WriteLine("el area del circulo es: "+area);
            }
        }
    }
}
