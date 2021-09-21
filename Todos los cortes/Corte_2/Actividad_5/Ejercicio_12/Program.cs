using System;

namespace Punto_12
{
    class Program
    {
        /*
        Ejercicio N°12
        Grupo de trabajo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Wilson Camilo Gamba Alvarez
        Realizado por: Jeison Julian Sastoque Silva
        */
        static void Main(string[] args)
        {
            int[,] Matz = new int[12, 12];
            int Fill;
            int Colums;

            Console.Write("\nMatriz Original\n      ");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("   " + Colums + "  ");
            }
            Console.WriteLine();

            Console.Write("    ┌");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("──────");
            }
            Console.WriteLine("┐");

            Random numAleatorio = new Random();
            for (Fill = 0; Fill < 12; Fill++)
            {
                if (Fill > 9)
                {
                    Console.Write("  " + Fill + "│");
                }
                else
                {
                    Console.Write("  " + Fill + " │");
                }

                for (Colums = 0; Colums < 12; Colums++)
                {
                    Matz[Fill, Colums] = numAleatorio.Next(0, 101);
                    if (Matz[Fill, Colums] < 10)
                    {
                        Console.Write("     " + Matz[Fill, Colums]);
                    }
                    else if (Matz[Fill, Colums] == 100)
                    {
                        Console.Write("   " + Matz[Fill, Colums]);
                    }
                    else
                    {
                        Console.Write("    " + Matz[Fill, Colums]);
                    }
                }
                Console.WriteLine("│");
            }
            Console.Write("    └");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("──────");
            }
            Console.WriteLine("┘");

            int[,] MatrizRotada = new int[12, 12];
            int ColumnaR = 11;
            for (Fill = 0; Fill < 12; Fill++)
            {
                int FilaR = 0;
                for (Colums = 0; Colums < 12; Colums++)
                {
                    MatrizRotada[FilaR, ColumnaR] = Matz[Fill, Colums];
                    FilaR++;
                }
                ColumnaR--;
            }

            Console.Write("\nMatriz Rotada con dirección a las manecillas del reloj\n      ");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("   " + Colums + "  ");
            }
            Console.WriteLine();

            Console.Write("    ┌");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("──────");
            }
            Console.WriteLine("┐");

            for (Fill = 0; Fill < 12; Fill++)
            {
                if (Fill > 9)
                {
                    Console.Write("  " + Fill + "│");
                }
                else
                {
                    Console.Write("  " + Fill + " │");
                }
                for (Colums = 0; Colums < 12; Colums++)
                {
                    if (MatrizRotada[Fill, Colums] < 10)
                    {
                        Console.Write("     " + MatrizRotada[Fill, Colums ]);
                    }
                    else if (MatrizRotada[Fill, Colums] == 100)
                    {
                        Console.Write("   " + MatrizRotada[Fill, Colums]);
                    }
                    else
                    {
                        Console.Write("    " + MatrizRotada[Fill, Colums]);
                    }
                }
                Console.WriteLine("│");
            }
            Console.Write("    └");
            for (Colums = 0; Colums < 12; Colums++)
            {
                Console.Write("──────");
            }
            Console.WriteLine("┘");
        }
    }
}