using System;
using System.Collections;
using System.Linq;

namespace EjercicioArray3
{
    class Program
    {
        static void llenarArray(int valorMin, int valorMax, int[] arrayNum){
            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = generarNumAleatorioPrimo(valorMin, valorMax);
            }
        }

        static void mostrarArray(int[] arrayNum){
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine((i+1)+". "+arrayNum[i]);
            }
            Console.WriteLine();
            Console.WriteLine("El número mayor del array es: "+ arrayNum.Max());
            Console.WriteLine("El número menor del array es: "+ arrayNum.Min());           
        }

        static ArrayList generarNumerosPrimos(int valorMin, int valorMax){
            ArrayList listaPrimos = new ArrayList();
            for (int i = valorMin; i <= valorMax; i++)
            {
                Boolean esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0){
                        esPrimo = false;
                        break;
                    }
                }
                if(esPrimo){
                    listaPrimos.Add(i);
                }
            }
            return listaPrimos;
        }

        static int generarNumAleatorioPrimo(int valorMin, int valorMax){
            Random random = new Random();
            ArrayList listPrimos = generarNumerosPrimos(valorMin, valorMax);
            int numAleatorio = random.Next(0, listPrimos.Count);
            int numAleatorioPrimo = (int)listPrimos[numAleatorio];
            return numAleatorioPrimo;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array");
            int size = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[size];
            Console.WriteLine("Ingrese el valor mínimo de los números aleatorios deseados");
            int valorMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor máximo de los números aleatorios deseados");
            int valorMax = int.Parse(Console.ReadLine());
            llenarArray(valorMin, valorMax, arrayNum);
            Console.WriteLine();
            mostrarArray(arrayNum);
        }
    }
}
