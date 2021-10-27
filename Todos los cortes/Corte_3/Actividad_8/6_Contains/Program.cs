using System;

namespace _6_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
           
           

                string s1 = "hombre araña";
                string s2;
               

                System.Console.WriteLine("Descubre la palabra secreta\n pista: Superheroe");
                System.Console.WriteLine("");
                System.Console.WriteLine("Escribe tu palabra");
                s2 = Console.ReadLine();
                

                bool b = s1.Contains(s2);
                Console.WriteLine("'{0}' esta en la cadena : {1}",
                                s2, b);
                                

                if (b)
                {
                    int index = s1.IndexOf(s2);
                    if (index >= 0)
                        Console.WriteLine("'{0} comienza en la posicion del caracter {1}",
                                      s2, index + 1);
                }
                if (s2 == s1)
                {
                    System.Console.WriteLine("Ganaste");

                }
                else
                {
                    System.Console.WriteLine("F Perdiste");
                }

                System.Console.WriteLine("Deseas intentar de nuevo S/N");
              opc = Console.ReadLine();
            
        }
    }
}
