using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //creacion de variables 
            
            float num1 =0.0f;
            float num2 =0.0f;
            float num3 =0.0f;
            float num4 =0.0f;
            float promedio =0.0f;
          
            string valor ="";
            System.Console.WriteLine("Programa para determinar el promedio");
            System.Console.WriteLine("");

            // interaccion con el usuario 
            // ingrsar datos

            System.Console.WriteLine("Por favor ingresar la primera nota");
            valor=Console.ReadLine();
            num1 = Convert.ToInt32(valor);

            System.Console.WriteLine("Por favor ingresar la segunda nota");
            valor=Console.ReadLine();
            num2 = Convert.ToInt32(valor);

            System.Console.WriteLine("Por favor ingresar la tercera nota");
            valor=Console.ReadLine();
            num3 = Convert.ToInt32(valor);

            System.Console.WriteLine("Por favor ingresar la cuarta nota");
            valor=Console.ReadLine();
            num4 = Convert.ToInt32(valor);

            //ciclo como encontar la mayor nota

            if (num1>num2 && num1>num3 && num1>num4){
                System.Console.WriteLine("Su mayor nota es:"+num1);
            }
            
            if (num2>num1 && num2>num3 && num2>num4){
                System.Console.WriteLine("Su mayor nota es:"+num2);
            }
            
            if (num3>num1 && num3>num2 && num3>num4){
                System.Console.WriteLine("Su mayor nota es:"+num3);
            }
            
            if (num4>num1 && num4>num2 && num4>num3){
                System.Console.WriteLine("Su mayor nota es:"+num4);
            }
            
            // ciclo para encontar la menor calificacion


            if (num1<num2 && num1<num3 && num1<num4){
                System.Console.WriteLine("Su menor  nota es:"+num1);
            }
            
            if (num2<num1 && num2<num3 && num2<num4){
                System.Console.WriteLine("Su menor nota es:"+num2);
            }
            
            if (num3<num1 && num3<num2 && num3<num4){
                System.Console.WriteLine("Su menor nota es:"+num3);
            }
            
            if (num4<num1 && num4<num2 && num4<num3){
                System.Console.WriteLine("Su menor nota es:"+num4);
            }

            
            // paso para encontra el promedio de la nota 
            promedio=(num1+num2+num3+num4) /4;

            System.Console.WriteLine("Su promedio es: " +promedio);

            


            
        }
    }
}
