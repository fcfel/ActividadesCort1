using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1;
            string c2;
            System.Console.WriteLine("ingrese una palabra de la cadena 1: ");
            c1=Console.ReadLine();

            System.Console.WriteLine("Ingrese una palabra de la cadena 2: ");
            c2=Console.ReadLine();

            if (c1.CompareTo(c2)==0)
            {
                System.Console.WriteLine("Las cadenas son iguales (compare)");
            }else
            {
                System.Console.WriteLine("Las cadenas no son iguales");
            }

            // Dos formas de llegar al mismo resultado

            if (c1==c2)
            {
                System.Console.WriteLine("Las cadenas son iguales (==)");
            }
        }
    }
}
