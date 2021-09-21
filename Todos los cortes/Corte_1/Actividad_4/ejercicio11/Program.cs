using System;

namespace Ejecicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] ciudades =new string [4,3];
            string [] paises =new string [4];
            System.Console.WriteLine("Introduzca el nombre de cuatro paises ");
            int i=0; int j=0;
            for ( i = 0; i <4; i++)
            {
                paises[i]=Console.ReadLine();
            }
            for ( i = 0; i < 4; i++)
            {
              System.Console.WriteLine("Introduzca tres ciudades de "+paises[i]+".");
              for (j= 0; j < 3; j++)
              {
                  ciudades[i,j]= Console.ReadLine();
              }  
            }

            System.Console.WriteLine("\nLos paises y ciudades introducidos son los siguientes:\n");
             for (i = 0; i <4; i++)
            {
                System.Console.Write("\nPaises: "+paises[i]+" \t ");
                for (j= 0; j <3; j++)
                {
                 System.Console.Write("Ciudades: " + ciudades [i,j] + "\t ");   
                }
            }
        }
    }
}
