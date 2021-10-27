using System;

namespace Clase_String_Método_TrimStart
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método TrimStart
    class Program{
        static void Main(string[] args){
            String n = "  ABC  ";
            String resultado = n.TrimStart();
            Console.WriteLine($"Cadena original     : \"{n}\"");
            Console.WriteLine($"TrimStart() Resultado : \"{resultado}\"");
        }
    }
}
