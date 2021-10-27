using System;
using System.Collections;
namespace Clase_String__Método_EndsWith
{
    //Grupo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Jesus David De La Cruz Mercado, Wilsom Camilo Gamba Alvarez
    //Materia: Estructura De Datos
    //Realizado por: Jeison Julian Sastoque Silva
    //Clase String, Método EndsWith
    class Program{
        public static void Main(string[] args){
            
           String[] Change = { "Black.", "Savage!", "Never.", 
                           "Esto es una Cadena.", "Legends" };
           foreach (var Kaku in Change) {
             bool Eyeofthe = Kaku.EndsWith(".");
             Console.WriteLine("'{0}' Termina en un período: {1}", 
                            Kaku, Eyeofthe);
            } 
        }
    }
}
