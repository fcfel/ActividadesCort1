using System;

namespace PUNTO_12
{
    class Program
    {

       static void Main(string[] args)
        {
           /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
            Console.WriteLine("BIENVENIDOS  " );
            Console.WriteLine("le mostraremos nuestras opciones con los productos disponibles en el momento" );
            Console.WriteLine("1. Producto1. " );
            Console.WriteLine("2. Producto2. " );
            Console.WriteLine("3. Producto3. " );
            Console.WriteLine("3. Produncto4(NORMAL). " );

            double Producto1   = 900;
            double Producto2  = 1600;
            double Producto3   = 3000;
            double Producto4   = 1900;
            String EN1,EN2,EN3,EN4;
            int cantidad1 = 1, cantidad2 = 1, cantidad3 = 1, cantidad4 =1;
            double proceso1   = 0;
            double proceso2   = 0;
            double proceso3  = 0; 
            double proceso4   = 0;
            double valor1   = 0;
            double valor2   = 0;
            double valor3   = 0;
            double valor4   = 0;
            double valor99  = 0;
            double valor88  = 0;
            double valor97  = 0;
            double valor98  = 0;
            double resultado  = 0;
 
            Console.WriteLine(" ");
            Console.WriteLine("Por favor digite el o los productos que desea llevar:" );
            Console.WriteLine("Presione (enter) la cantidad de veces que sea necesaria dependiendo la canidad de productos para continuar con el proceso." );
            EN1 = Console.ReadLine();
            EN2 = Console.ReadLine();
            EN3 = Console.ReadLine();
            EN4 = Console.ReadLine();

            Console.WriteLine("Ahora por favor ingrese la cantidad de metros que desea llevar segun el procuto" );
            Console.WriteLine("Si no agrego los 4 productos en los espacios ponga el numero 0." );
            Producto1 = Convert. ToInt32(Console.ReadLine());
            Producto2 = Convert. ToInt32(Console.ReadLine());
            Producto3 = Convert. ToInt32(Console.ReadLine());
            Producto4 = Convert. ToInt32(Console.ReadLine());
            
           if(Producto1 <=40){
              Console.WriteLine("Tiene un descuento del 5%." );
              proceso1 = Producto2*cantidad1; 
              valor1 = proceso1*0.5;
              valor99 = proceso1-valor1;
              Console.WriteLine("Su total hasta el momento es: "+valor99);
           } 
           if(cantidad1 > 40){
              Console.WriteLine("Tiene un descuento del 12%." );
              proceso1 = Producto2*cantidad1; 
              valor1 = proceso1*0.12;
              valor99 = proceso1-valor1;
              Console.WriteLine("Su total hasta el momento es: "+valor99);
           }
           if(cantidad2 <=40){
              Console.WriteLine("Tiene un descuento del 5%." );
              proceso2 = Producto1*cantidad2;
              valor2 = proceso2*0.5;
              valor88 = proceso2 - valor2;
              Console.WriteLine("Su total hasta el momento es: "+valor88);
           }
          if(cantidad2 > 40){
              Console.WriteLine("Tiene un descuento del 12%." );
              proceso2 = Producto1*cantidad2;
              valor2 = proceso2*0.12;
              valor88 = proceso2 - valor2;
              Console.WriteLine("Su total hasta el momento es: "+valor88);
           }
            if(cantidad3 <=40){
              Console.WriteLine("Tiene un descuento del 5%." );
              proceso3 = Producto3*cantidad3;
              valor3 = proceso3*0.5;
              valor97 = proceso3 - valor3;
              Console.WriteLine("Su total hasta el momento es: "+valor97);
           }
           if(cantidad3 > 40){
              Console.WriteLine("Tiene un descuento del 12%." );
             proceso3 = Producto3*cantidad3;
              valor3 = proceso3*0.12;
              valor97 = proceso3 - valor3;
              Console.WriteLine("Su total hasta el momento es: "+valor97);
           }
            if(cantidad4 <=40){
              Console.WriteLine("Tiene un descuento del 5%." );
              proceso4 = Producto4*cantidad4;
              valor4 = proceso4*0.5;
              valor98 = proceso4 - valor4;
              Console.WriteLine("Su total hasta el momento es: "+valor98);
           }
           if(cantidad4 > 40){
              Console.WriteLine("Tiene un descuento del 12%." );
             proceso4 = Producto4*cantidad4;
              valor4 = proceso4*0.12;
              valor98 = proceso4 - valor4;
              Console.WriteLine("Su total hasta el momento es: "+valor98);
           }
         resultado = valor99 + valor88 + valor97 + valor98;
         Console.WriteLine("EL VALOR TOTAL DE LA FACTORA ES: "+resultado);

         Console.ReadKey();
        }
    }
}