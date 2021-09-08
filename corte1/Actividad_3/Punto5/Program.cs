using System;
//trabajo realizado por: Felipe Cruz, Jeison Sastoque, Jesus De La Cruz, Wilson Gamba
namespace PUNTO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dig1;
            int Dig2;
            int Dig3;
            int S;
            int opcion;

            Console.Write("Ingrese 4 digitos " );
            Console.Write("RECUERDE!" );
            Console.Write(" No se puede ingresar el mismo numero dos veces");

            Console.Write(" Digita el primer número " );
            Dig1 = int.Parse(Console.ReadLine());

            Console.Write(" Digita el segundo número " );
            Dig2 = int.Parse(Console.ReadLine());

            Console.Write(" Digita el tercer número " );
            Dig3 = int.Parse(Console.ReadLine());

            Console.Write(" Digita el cuarto número " );
            S = int.Parse(Console.ReadLine());

            if (Dig1 == Dig2 || Dig1 == Dig3 || Dig1 == S || Dig2 == Dig1 || Dig2 == Dig3 || Dig2 == S || Dig3 == Dig1 || Dig3 == Dig2 || Dig3 == S || S == Dig1 || S == Dig2 || S == Dig3)
            {
                Console.WriteLine("Lo lamento algun numero se repite" );
            }
    
            {
                Console.WriteLine("MENÚ" );
                Console.WriteLine("1. ¿Qué número es mayor? " );  
                Console.WriteLine("2. ¿Qué número es menor? " ); 

                Console.Write("Que opcion desea elegir: " );
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (Dig1 > Dig2)
                        {
                            if (Dig1 > Dig3)
                            {
                                if (Dig1 > S)
                                {
                                    Console.WriteLine("El número mayor es: "+ Dig1);
                                }
                            }
                        }

                        if (Dig2 > Dig1)
                        {
                            if (Dig2 > Dig3)
                            {
                                if (Dig2 > S)
                                {
                                    Console.WriteLine("El número mayor es: "+ Dig2);
                                }
                            }
                        }

                        if (Dig3 > Dig1)
                        {
                            if (Dig3 > Dig2)
                            {
                                if (Dig3 > S)
                                {
                                    Console.WriteLine("El número mayor es: "+ Dig3);
                                }
                            }
                        }

                        if (S > Dig1)
                        {
                            if (S > Dig2)
                            {
                                if (S > Dig3)
                                {
                                    Console.WriteLine("El número mayor es: "+ S);
                                }
                            }
                        }
                    break;

                    case 2:
                        if (Dig1 < Dig2)
                        {
                            if (Dig1 < Dig3)
                            {
                                if (Dig1 < S)
                                {
                                    Console.WriteLine("El número menor es: "+ Dig1);
                                }
                            }
                        }

                        if (Dig2 < Dig1)
                        {
                            if (Dig2 < Dig3)
                            {
                                if (Dig2 < S)
                                {
                                    Console.WriteLine("El número menor es: "+ Dig2);
                                }
                            }
                        }

                        if (Dig3 < Dig1)
                        {
                            if (Dig3 < Dig2)
                            {
                                if (Dig3 < S)
                                {
                                    Console.WriteLine("El número menor es: "+ Dig3);
                                }
                            }
                        }

                        if (S < Dig1)
                        {
                            if (S < Dig2)
                            {
                                if (S < Dig3)
                                {
                                    Console.WriteLine("El número menor es: "+ S);
                                }
                            }
                        }
                     break;
                } 
            }
        }
    }
}