using System;

namespace EjercicioArray2
{
    class Program
    {
        static void llenarArray(int valorMin, int valorMax, int[] arrayNum){
            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = generarNumAleatorio(valorMin, valorMax);
            }
        }

        static void mostrarArray(int[] arrayNum){
            int suma = 0;
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine((i+1)+". "+arrayNum[i]);
                suma += arrayNum[i];
            }
            Console.WriteLine();
            Console.WriteLine("La suma de todos los valores es: "+ suma);
        }

        private static int generarNumAleatorio(int valorMin, int valorMax){
            Random random = new Random();
            int numAleatorio = random.Next(valorMin, valorMax);
            return numAleatorio;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array");
            int size = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[size];
            llenarArray(0, 10, arrayNum);
            Console.WriteLine();
            Console.WriteLine("-------- Impresión array --------");
            mostrarArray(arrayNum);
        }
    }
}
