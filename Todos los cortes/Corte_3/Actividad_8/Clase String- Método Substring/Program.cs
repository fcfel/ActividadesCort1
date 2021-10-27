using System;
using System.Collections;
namespace Clase_String__Método_Substring
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método Substring
    class Program{
        static void Main(string[] args){
            
            String[] Liebes = { "Class=String", "Method=Substring", "Name=Carlos", "Materia=Estructura De Datos", "Semestre=Segundo"  };
            foreach (var Liebe in Liebes){
                int remember = Liebe.IndexOf("=");
                if (remember < 0)
                    continue;
                Console.WriteLine(" {0},  '{1}'",
                    Liebe.Substring(0, remember),
                    Liebe.Substring(remember + 1));
            }
        }
    }
}
