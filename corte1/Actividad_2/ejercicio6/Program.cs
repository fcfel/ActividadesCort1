using System;

namespace punto6
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            string entrada2;
            int entrada = 0;
            int opc = 0;
            Console.WriteLine("Por favor escoja la opcion que desee entre 1 y 2.");
            Console.WriteLine("1. Programa para pasar un numero a letras.");
            Console.WriteLine("2. Programa para pasar letras a numeros.");
            opc = int.Parse(System.Console.ReadLine());
            
            if (opc == 1){
              System.Console.WriteLine("Opcion 1: ");
                Console.WriteLine("Ingrese un valor entre 1 y 5:");
              entrada = int.Parse(System.Console.ReadLine());
              switch (entrada){
                case 1: 
                Console.WriteLine("Uno");
                break;
                case 2: 
                Console.WriteLine("Dos");
                break;
                case 3: 
                Console.WriteLine("Tres");
                break;
                case 4: 
                Console.WriteLine("Cuatro");
                break;
                case 5: 
                Console.WriteLine("Cinco");
                break;
                default: Console.WriteLine("Se ingreso un valor fuera de rango"); break;
              }
            }
           
           if (opc ==2){
               Console.WriteLine("Opcion 2:");
               Console.WriteLine("Escriba un número en español entre uno y cinco:");
               entrada2 = Console.ReadLine();
               switch (entrada2){
                case "Uno": 
                Console.WriteLine(1);
                break;
                case "Dos": 
                Console.WriteLine(2);
                break;
                case "Tres": 
                Console.WriteLine(3);
                break;
                case "Cuatro": 
                Console.WriteLine(4);
                break;
                case "Cinco": 
                Console.WriteLine(5);
                break;
                default: Console.WriteLine("Debe ingresar un valor entre uno y cinco"); break;
                }
           }
           Console.ReadKey();
        }
    }
}
