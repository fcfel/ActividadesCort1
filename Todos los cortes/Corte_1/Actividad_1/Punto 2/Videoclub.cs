using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creacion de variables 
            double Peli1;
            double Peli2;
            double Peli3;
            double Total;
            
            //interaccion con el usuario

            Console.Write("Ingrese el primer valor ");
            Peli1 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor ");
            Peli2 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer valor ");
            Peli3 =
                double.Parse(Console.ReadLine());

            // este ciclo permite encontar los menores precios para poder aplicar la promocion

            if (Peli1 > Peli2 && Peli1 > Peli3)
            {
                Total = Peli2 + Peli3;
                Console.WriteLine("El total a pagar con la promocion es: " + Total);
            }
             
            else if (Peli2 > Peli1 && Peli2 > Peli3)
            {
                Total = Peli1 + Peli3;
                Console.WriteLine("El total a pagar con la promocion es: " + Total);
            }
            else
            {
               Total = Peli2 + Peli1;
                Console.WriteLine("El total a pagar con la promocion es: " + Total);
            }
    }
}
  }