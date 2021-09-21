using System;

namespace Punto_4
{
    /*
        Ejercicio N°4
        Grupo de trabajo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Wilson Camilo Gamba Alvarez
        Realizado por: Jeison Julian Sastoque Silva
        */
    class Program
    {
       
        double[,] Matz = new double[5, 5];
        double[,] TransL = new double[5, 5];
        int Cont = 0;
        int WhileLoop = 0;

        public void Ingresar()
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese los datos para llenar la matriz (Si va ingresar decimales es con ',')");

                    for (int a = 0; a < 5; a++)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            Console.Write("- ");
                            Matz[a, c] = double.Parse(Console.ReadLine());
                            WhileLoop = 0;
                        }
                    }
                }
               catch (System.FormatException )
                {
                    Console.WriteLine(" SOLO SON VALIDADOS NUMEROS PUEDEN SER ENTEROS O CON DECIMALES PERO CON ',' ");
                    WhileLoop = 1;
                }
            } while (WhileLoop == 1);
        }

        public void Imprimir()
        {
            Console.WriteLine("Esta es la matriz normal:\n");

            for(int a=0;a<5;a++)
            {
                for(int c=0;c<5;c++)
                {
                    Console.Write($"\t {Matz[a, c]}");//  {Matriz[f, c+1]}  {Matriz[f, c+2]}  {Matriz[f, c+3]}  {Matriz[f, c+4]}  |");
                    Cont = Cont + 1;
                    if (Cont == 5)
                    {
                        Console.WriteLine("");
                        Cont = 0;
                    }
                }
            }
        }

        public void Transpuesta()
        {
            Console.WriteLine("Esta es la matriz transpuesta:\n");           

            for(int a=0;a<5;a++)
            {
                for(int c=0;c<5;c++)
                {
                    TransL[a, c] = Matz[c, a];                 
                }
            }

            Cont = 0;

            for (int a = 0; a < 5; a++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write($"\t {TransL[a, c]}");// {Matriz[f, c + 1]}  {Matriz[f, c + 2]}  {Matriz[f, c + 3]}  {Matriz[f, c + 4]}  |");
                    Cont = Cont + 1;

                    if(Cont==5)
                    {
                        Console.WriteLine("");
                        Cont = 0;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            String Reiniciar = "";
            do
            {
                Program pv = new Program();
                pv.Ingresar();
                pv.Imprimir();
                pv.Transpuesta();

                Console.WriteLine("¿Desea repetir el programa?");
                Reiniciar = Console.ReadLine();
            } while (Reiniciar == "s" || Reiniciar == "S");
        }
    }
}