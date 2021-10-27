using System;
using System.Collections;
namespace Clase_String_Método_CopyTo
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método CopyTo
    class Program{
        public static void Main() {

            string compare = "runnerl";
            char [] remove1 = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                                'a', 'r', 'r', 'a', 'y' };

                Console.WriteLine( remove1 );

                compare.CopyTo ( 0, remove1 , 4, compare.Length );

                Console.WriteLine( remove1 );

                compare = "A different string";

                compare.CopyTo ( 2, remove1 , 3, 9 );

                Console.WriteLine( remove1 );
        }
    }
}
