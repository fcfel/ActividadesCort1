using System;
using System.Collections;
namespace Clase_String_Método_Insert
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método Insert
    class Program{
        public static void Main(){
            
            string animal1 = "alligator";
            string animal2 = "Eagle";

            string Android = String.Format("The {0} jumps over the {1}.", animal1, animal2);

            Console.WriteLine("The original string is:{0}{1}{0}", Environment.NewLine, Android);

            Console.Write("Enter an adjective (or group of adjectives) " + "to describe the {0}: ==> ", animal1);
            string adj1 = Console.ReadLine();

            Console.Write("Enter an adjective (or group of adjectives) " + "to describe the {0}: ==> ", animal2);
            string adj2 = Console.ReadLine();

            adj1 = adj1.Trim() + " ";
            adj2 = adj2.Trim() + " ";

            Android = Android.Insert(Android.IndexOf(animal1), adj1);
            Android = Android.Insert(Android.IndexOf(animal2), adj2);

            Console.WriteLine("{0}The final string is:{0}{1}", Environment.NewLine, Android);
        }
    }
}
