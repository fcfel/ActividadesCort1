using System;

namespace EjercicioMatricesBi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz=new int[4,5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Introduzca 1 numero entero");
                    int num=int.Parse(Console.ReadLine());
                    matriz[i,j]=num;
                }
            }

            int[] filaSize=new int [4];
            int[] columnSize=new int[5];
            

            Console.WriteLine();
            Console.WriteLine("--- Impresión de matriz ---");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i,j]+ "    ");
                    columnSize [j] += matriz [i,j];
                    filaSize [i] += matriz [i,j];
                }
                Console.WriteLine();
            }
            int sumaTotal= 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("La suma de la fila "+(i+1)+" es: "+filaSize[i]);
                sumaTotal+= filaSize[i];
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("La suma de la columna "+(j+1)+" es: "+columnSize[j]);
                sumaTotal+= columnSize[j];
            }

            Console.WriteLine ("La suma total de la matriz es: "+sumaTotal);
        }    
    }
}
