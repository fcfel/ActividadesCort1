using System;

namespace PUNTO_2
{
    class Program
    {
        static void Main(string[] args)
       {
            Console.WriteLine("Ingrese el número de latas");
            int num = int.Parse(Console.ReadLine());
            int[] arreglo = new int[num];
            llenarMatriz(arreglo);
            Boolean esApilable = comprobarNumero(arreglo, num);
            if(esApilable){
                Console.WriteLine("El número es apilable");
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("* ");
                    if(comprobarNumero(arreglo, i)){
                        Console.WriteLine();
                    }        
                }
            }else{
                Console.WriteLine("El número no es apliable");
            }
        }

        static void llenarMatriz(int[] array){
           for (int i = 0; i < array.Length; i++)
           {
               array[i] = (i+1)*(i+2)/2;
           }
        }
        static Boolean comprobarNumero(int[] array, int n){
            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
