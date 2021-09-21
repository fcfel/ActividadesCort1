using System;

namespace Punto9
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] dimension=new int [5,15];

           int num_filas, num_cols;
           int col;
           num_filas=5;
           num_cols=15;
           for(int fila=0;fila<num_filas;fila++)
              {
               for (col = 0; col <num_cols; col++)
               {
      
  
           if (fila == 0 || fila == num_filas - 1 || col == 0 || col == num_cols - 1)
					{

						dimension[fila, col] = 1;
					}
				 
				   else
					{

						dimension[fila, col] = 0;
					}

				}
			}

			for (int fila = 0; fila < num_filas ; fila++) {
				for (col = 0; col < num_cols ; col++) {
					 Console.Write(dimension[fila, col]);
				}
				Console.WriteLine("");

			}
			
		}
    }
}
