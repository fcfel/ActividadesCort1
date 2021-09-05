using System;

namespace PUNTO_10
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            float Largo =0.0f;
            float Ancho= 0.0f;
            double mts2,preTotal = 0;
            float precio;

            Console.Write("Ingrse Largo: ");
            Largo = float.Parse(System.Console.ReadLine());

            Console.Write("Ingrese Ancho: ");
            Ancho = float.Parse(System.Console.ReadLine());

            Console.Write("Ingrese el Precio en Mts2: ");
            precio = float.Parse(System.Console.ReadLine());

            mts2 = Largo * Ancho;
            preTotal = precio * mts2;
            if (mts2> 400 && mts2 < 1000)
            {
             preTotal = (preTotal) -  (preTotal*0.10);   
            }
            if (mts2> 500 && mts2 < 1000)
            {
              preTotal = (preTotal) -  (preTotal*0.17);
            }
            else if(mts2 > 1000)
            {
              preTotal = (preTotal) -  (preTotal*0.25);
            }
            Console.WriteLine("Los Mts son: " + mts2);

            Console.WriteLine("Valor del terreno: " + preTotal);
        }
    }
}
