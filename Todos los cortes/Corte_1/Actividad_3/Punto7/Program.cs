using System;

namespace PUNTO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Por favor ingrese el primer numero");
            num1 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Por favor ingrese el segundo numero");
            int num2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese 'i' para ver los numeros impares o ingrese 'p' para ver numeros pares");
            string imp=Console.ReadLine();

            if (imp=="p")
            {
             for (int i = num1; i <=num2; i++)
             {
                 if (i%2==0)
                 {
                     System.Console.WriteLine(i);
                 }
             }   
            }
            else if (imp=="i")
            {
                for (int j = num1; j<=num2; j++)
                {
                    if (j%2!=0)
                    {
                        System.Console.WriteLine(j);
                    }
                }
               
            }
             else
                {
                    System.Console.WriteLine("Letra invalida, es imposible hacer la operacion");
                }

        }
    }
}
