using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
 
        char[] mayusculas= new char[26];
        for (int i = 65, j = 0; i <= 90; i++, j++) {
            mayusculas[j] = (char) i;
        }
 
        String cadena = "";
        int eleccion = -1;
            System.Console.WriteLine("Digite '-1' para poder visualizar la cadena de texto");

 
        do {
            System.Console.WriteLine("Elija un indice entre 0 y " + (mayusculas.Length - 1));
            eleccion = int.Parse(Console.ReadLine());
 
            if (!(eleccion >= 0 && eleccion <= mayusculas.Length - 1)) {
                System.Console.WriteLine("Error, inserte otro numero");
            } else {
                if (eleccion != -1) {
                    cadena += mayusculas[eleccion];
                }
            }
 
        } while (eleccion != -1);
 
        System.Console.WriteLine("Esta es la cadena de texto que ha creado " +cadena);
 
    }
 
}
        }
    
