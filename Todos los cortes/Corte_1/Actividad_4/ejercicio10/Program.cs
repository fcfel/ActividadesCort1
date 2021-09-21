using System;

namespace ejerrcicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string idioma="";
            
            int [,] estudiante = new int [3,4 ];

           int i=0;
            while (i<4)
            {
               if (i==0)
               {
                   idioma="ingles";
               }else if (i==1)
               {
                   idioma="frances";
               }else if (i==2)
               {
                   idioma="aleman";
               }else if (i==3)
               {
                   idioma="ruso";
               }
               
               System.Console.WriteLine("Escriba numero de estudiantes en nivel basico de "+idioma);
               estudiante[0,i] =int.Parse(Console.ReadLine());
               System.Console.WriteLine("Escriba numero de estudiantes en nivel medio de "+idioma);
               estudiante[1,i] =int.Parse(Console.ReadLine());
               System.Console.WriteLine("Escriba numero de estudiantes en nivel perfecc de "+idioma);
               estudiante[2,i] =int.Parse(Console.ReadLine());
               i++;
            }
            System.Console.WriteLine("Ingles:     basico= "+estudiante[0,0]+ " medio= "+estudiante[1,0]+" perfeccionalista= "+estudiante[2,0]);
            System.Console.WriteLine("frances:    basico= "+estudiante[0,1]+ " medio= "+estudiante[1,1]+" perfeccionalista= "+estudiante[2,1]);
            System.Console.WriteLine("aleman:     basico= "+estudiante[0,2]+ " medio= "+estudiante[1,2]+" perfeccionalista= "+estudiante[2,2]);
            System.Console.WriteLine("ruso:       basico= "+estudiante[0,3]+ " medio= "+estudiante[1,3]+" perfeccionalista= "+estudiante[2,3]);
        }
    }
}
