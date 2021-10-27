using System;
using System.Collections;
using System.Collections.Generic;

namespace Actividad_8_Problema_1
{
    class Actividad_8_Problema_1
    {
        static void Main(string[] args)
        {

            // string WhileLoop = "";
            String CadenaOri = "";
            //string Frase3 = "";
            int Opcion = 0;
            //int  Num = 0;
            //bool Encontrar = false;

            while (Opcion != 1)
            {

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Menu");

                Console.WriteLine("13. Inserta una letra en la parte derecha de la cadena (PadRight)");
                Console.WriteLine("14. Permite eliminar caracteres desde ubicacion x hasta ubicacion x (Remove)");
                Console.WriteLine("15. Remplazar un caracter por otro (Replace)");
                Console.WriteLine("16. En cada renglon escribe una palabra de la cadena (Split)");
                Console.WriteLine("17. Pone toda la cadena en minusculas (ToLower)");
                Console.WriteLine("18. Pone toda la cadena en MAYUSCULAS (ToUppert)");
                System.Console.WriteLine("Ingresa un numero '1' para salir del programa");
                Opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------");

                Console.WriteLine("Ingrese la palabra o frase a manipular");
                CadenaOri = Console.ReadLine();
                string CadenaOriginal = CadenaOri;
                Console.WriteLine("--------------------");
                Console.WriteLine($"La cadena original = {CadenaOriginal} se transformo a = {CadenaOri}");
                Console.WriteLine("------------------");

                //  Console.Clear();
                //Console.WriteLine("----------------------------------");
                //Console.WriteLine($"Escogio la opcion {Opcion}");

                switch (Opcion)
                {
                    case 13:
                        Console.WriteLine($"La cadena tiene {CadenaOri.Length} posiciones para que se puedan insertar algo debe ser mayor a ese numero");
                        int EspaIz = int.Parse(Console.ReadLine());
                        Console.WriteLine("Que letra va a ingresar a la parte de la derecha para la cadena");
                        char Nuevo = char.Parse(Console.ReadLine());

                        CadenaOri = CadenaOri.PadRight(EspaIz, Nuevo);
                        Console.WriteLine($"La nueva cadena es esta \"{CadenaOri}\"");

                        break;

                    case 14:
                        Console.WriteLine($"Que letra desea remplazar de la cadena {CadenaOri}?");
                        char Remplazo1 = char.Parse(Console.ReadLine());

                        Console.WriteLine($"¿Que desea ingresar en el lugar de la {Remplazo1}?");
                        char Remplazo2 = char.Parse(Console.ReadLine());

                        CadenaOri = CadenaOri.Replace(Remplazo1, Remplazo2);

                        Console.WriteLine($"La cadena quedo asi = {CadenaOri}");
                        break;

                    case 15:
                        Console.WriteLine($"Que letra desea remplazar de la cadena {CadenaOri}?");
                        char Rem1 = char.Parse(Console.ReadLine());

                        Console.WriteLine($"¿Que desea ingresar en el lugar de la {Rem1}?");
                        char Rem2 = char.Parse(Console.ReadLine());

                        CadenaOri = CadenaOri.Replace(Rem1, Rem2);

                        Console.WriteLine($"La cadena quedo asi = {CadenaOri}");
                        break;

                    case 16:
                        Console.WriteLine($"La cadena es esta {CadenaOri}");
                        string[] word = CadenaOri.Split();

                        Console.WriteLine($"Y quedo asi:");
                        foreach (var words in word)
                        {
                            Console.WriteLine($"- {words}");
                        }
                        break;

                    case 17:
                        Console.WriteLine($"La cadena es esta {CadenaOri}");
                        CadenaOri = CadenaOri.ToLower();

                        Console.WriteLine($"Se paso a minusculas quedo asi {CadenaOri}");
                        break;

                    case 18:
                        Console.WriteLine($"La cadena es esta {CadenaOri}");
                        CadenaOri = CadenaOri.ToUpper();

                        Console.WriteLine($"Se paso a MAYUSCULAS quedo asi {CadenaOri}");
                        break;
                }


                Console.WriteLine("GRACIAS");

            }

        }
    }
}
