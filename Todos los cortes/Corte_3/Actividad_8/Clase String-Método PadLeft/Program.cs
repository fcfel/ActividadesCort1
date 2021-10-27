using System;
namespace Clase_String_Método_PadLeft
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método PadLeft
    class Program{
        static void Main(string[] args){
          
            string stop = "MaxxAudio";
            char pad = '^';
            string result;
     
         /* Devuelve una cadena de longitud 5
           Rellenado con '^' a la izquierda */
         result = stop.PadLeft(5, pad);
         Console.WriteLine("Resultado: " + result); 

         result = stop.PadLeft(3, pad);
         Console.WriteLine("Resultado: " + result);  

         /* Devuelve una cadena de longitud 28
           Rellenado con '^' a la izquierda */
         result = stop.PadLeft(28, pad);
         Console.WriteLine("Resultado: " + result);  
 
         Console.ReadLine();
        }
    }
}
