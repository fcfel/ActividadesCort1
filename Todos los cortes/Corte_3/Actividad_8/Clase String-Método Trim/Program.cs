using System;
namespace Clase_String_Método_Trim
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método Trim
    class Program{
        static void Main(string[] args){
            string receta = "\n\n\n Hielo\ncrema  \n\n";
            string crema = "\n\n\n Ron con pasas  \n\n";

            string pasas = receta.Trim();
            Console.WriteLine(pasas);

            string leche = crema.Trim();
            Console.WriteLine(leche);

            Console.ReadLine();
        }
    }
}
