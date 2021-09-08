using System;

namespace EjercicioArray1
{
    class Program
    {
        static void llenarArreglo(int[] arrayNum){
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine("Digite un número");
                arrayNum[i] = int.Parse(Console.ReadLine());
            }
        }

        static float[,] multiplicarDividirArray(int[] arrayNum){
            float[,] resultados = new float[15, 3];
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine("Digite un número para multiplicar y dividir con el número en la posicion "+ (i+1));
                int num = int.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        resultados[i,j] = num;
                    }
                    else if (j == 1)
                    {
                        resultados[i, j] = ((float)(arrayNum[i])) * ((float)num);
                    }else{
                        resultados[i, j] = ((float)arrayNum[i]) / ((float)num);
                    }

                }
            }
            return resultados;
        }
        static void mostrarArreglo(int[] arrayNum, float[,] resultados){
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine((i+1)+". "+arrayNum[i]+"  Operado con: "+resultados[i,0]+"  Multiplicación: "+ resultados[i,1]+"  División: "+ resultados[i,2]);
            }
        }


        static void Main(string[] args)
        {
            int[] arrayNum = new int[15];
            llenarArreglo(arrayNum);
            float[,] resultados = multiplicarDividirArray(arrayNum);
            Console.WriteLine();
            Console.WriteLine("-------- Impresion del arreglo --------");
            mostrarArreglo(arrayNum, resultados);
        }
    }
}