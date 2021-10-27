using System;

namespace Clase_String_Método_LastIndexOf
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método LastIndexOf
    class Program{
        public static void Main(string[] args){
            
            string str = "icecream";

            int Index = 2;
            int japp = 3;

            StringComparison Cart1 = StringComparison.CurrentCultureIgnoreCase;
            StringComparison Cart2 = StringComparison.CurrentCulture;

            // ignores letter case
            int Last = str.LastIndexOf("CE", Index, japp, Cart1);
            Console.WriteLine(Last);

           // considers letter case
           int Last2 = str.LastIndexOf("CE", Index, japp, Cart2);
            Console.WriteLine(Last2);

           Console.ReadLine();
        }
    }
}
