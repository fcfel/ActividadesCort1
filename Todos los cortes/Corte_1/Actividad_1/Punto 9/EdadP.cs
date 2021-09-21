using System;

namespace Punto_9
{
    class Program
    {
        static void Main(string[] args)
        { //creacion de variables 

            float edad_perro =0.0f;
            float edad_hum =0.0f;
            float resultado =0.0f;
            string teclado="";

            System.Console.WriteLine("ingrese la edad de la persona ");
            teclado = Console.ReadLine();
            edad_hum = Convert.ToInt32(teclado);

            // if condicional para determinar la edad del perro

            if(edad_hum<2){
              

                edad_hum = 10.5f;
            }
            else
            {
                edad_perro = 21 + (edad_hum-2)*4 ; 
                
               
            }
            if(edad_hum>0){

                 resultado = edad_perro ;

            System.Console.WriteLine("la edad del perro es: "+resultado);

            }
            }
        }
    }
