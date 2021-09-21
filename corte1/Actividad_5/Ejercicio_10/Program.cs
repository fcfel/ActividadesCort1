using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] num = new int[6,10];
           int fila;
           int columna;
           int minimo;
           minimo = int.MaxValue;
           int filaMinimo=0;
           int columnaMinimo=0;

           Random rnd =new Random();

           int maximo; 
            maximo =int.MinValue;
            int filaMaximo=0;
            int columnaMaximo=0;

            System.Console.Write("\n   "  );
            for(columna=0;columna<10;columna++)
            {
            System.Console.Write("  " + columna + "  ");
            }
            System.Console.WriteLine();

            System.Console.Write("   ");
            for(columna=0; columna<10; columna++)
            {
            System.Console.Write("──────");
            }
            System.Console.WriteLine();

            for(fila = 0; fila < 6; fila++) {
            System.Console.WriteLine("  " + fila + " │");
            for(columna = 0; columna < 10; columna++) {
            num[fila,columna] = (int)(rnd.Next(0,1000));
            System.Console.Write("xd", num[fila,columna]);
       

            if (num[fila,columna] < minimo) {
            minimo = num[fila,columna];
            filaMinimo = fila;
            columnaMinimo = columna;
          }
             if (num[fila,columna] > maximo) {
            maximo = num[fila,columna];
            filaMaximo = fila;
            columnaMaximo = columna;
             }
              }
              System.Console.WriteLine("|");

              System.Console.Write("");
              for(columna = 0; columna < 10; columna++) {
            System.Console.Write("──────");
            }
            System.Console.WriteLine("\n\nEl máximo es " + maximo + " y está en la fila " + filaMaximo + ", columna " + columnaMaximo);
            System.Console.WriteLine("El mínimo es " + minimo + " y está en la fila " + filaMinimo + ", columna " + columnaMinimo);
        
        }
    }
}
}
