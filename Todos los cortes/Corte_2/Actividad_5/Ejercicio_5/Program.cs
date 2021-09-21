using System;

namespace Punto_5
{
    /*
        Ejercicio N°5
        Grupo de trabajo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Wilson Camilo Gamba Alvarez
        Realizado por: Jeison Julian Sastoque Silva
        */
    class Program
    {
        private int[,] matz;
        private int[,] Resultadodmatriz;

        public void Ingresar()
        {

            matz = new int[3, 3];
            Resultadodmatriz = new int[3, 3];

            Console.WriteLine("\n BIENVENIDO n");
            for (int fill = 0; fill < 3; fill++)
            {
                for (int colums = 0; colums < 3; colums++)
                {
                    Console.Write("Ingrese el número de la posición ["+(fill+1)+","+(colums+1)+"]: ");
                    string line;
                    line = Console.ReadLine();
                    matz[fill, colums] = int.Parse(line);
                }
            }
        }

        public void ImprimirOrigin()
        {
            Console.Write("\n Matriz Original: \n");
            for (int fill = 0; fill < 3; fill++)
            {
                for (int colums = 0; colums < 3; colums++)
                {
                    Console.Write(matz[fill, colums] + " ");
                }
                Console.WriteLine();
            }
            
        }
        public void ImprimirTrans()
        {
            Console.Write("\n Matriz Transpuesta: \n");
            for (int fill = 0; fill < 3; fill++)
            {
                for (int colums = 0; colums < 3; colums++)
                {
                    Console.Write(matz[colums, fill] + " ");
                }
                Console.WriteLine();
            }
            for (int fill = 0; fill < 3; fill++)
            {
                for (int colums = 0; colums < 3; colums++)
                {
                    Resultadodmatriz [fill,colums]=matz[fill, colums]+matz[colums, fill];
                }
            }
        }
        public void ImprimirSuma()
        {
            Console.WriteLine("\n La suma de la Matriz Original y Matriz Transpuesta es: ");
            for (int fill = 0; fill < 3; fill++)
            {
                Console.Write("\n");
                for (int colums = 0; colums < 3; colums++)
                {
                    Console.Write(Resultadodmatriz[fill,colums]+"  ");

                }
            }

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program so = new Program();
            so.Ingresar();
            so.ImprimirOrigin();
            so.ImprimirTrans();
            so.ImprimirSuma();
        }
    }
}