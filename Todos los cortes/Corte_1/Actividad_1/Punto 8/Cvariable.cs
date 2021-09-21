using System;

namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string letra;
            //iniciamos ciclo do while 
            do
            {
            Console.WriteLine("Digite un caracter");
            letra=Console.ReadLine();
            //if para determinar si es vocal o no
             
            if (letra=="a"||letra=="e"||letra=="i"||letra=="o"||letra=="u") {
                
                System.Console.WriteLine("El caracter {0} es una vocal",letra);
            }
            // else if para determinar si es consonate

               else if (letra=="q"||letra=="w"||letra=="r"||letra=="t"||letra=="y"||letra=="p"||letra=="s"||
                letra=="d"||letra=="f"||letra=="g"||letra=="h"||letra=="j"||letra=="k"||letra=="l"||letra=="ñ"||
                letra=="z"||letra=="x"||letra=="c"||letra=="v"||letra=="b"||letra=="n"||letra=="m") {

                 System.Console.WriteLine("El caracter {0} es una consonate",letra);  
                 
                 }
                 //else de descarte si no se cumplen las demas reglas
                 else
                 {
                     System.Console.WriteLine("El caracter {0} es un simbolo del sistema",letra);
                 }
            
        //cerramos ciclo con while
            } while (letra!="?");
            
        }
    }
}
