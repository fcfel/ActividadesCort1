using System;

namespace Clase_String_Método_TrimEnd
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método TrimEnd
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abc";
            String result = str.TrimEnd();
            Console.WriteLine($"Original String     : \"{str}\"");
            Console.WriteLine($"Result of TrimEnd() : \"{result}\"");
        }
    }
}
