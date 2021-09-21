using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
             /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
         float nu1  =  0.0f;
            float nu2 = 0.0f;
            float resultado = 0.0f;
            string valor =  "";
            int opcion = 0;


           Console.WriteLine("porfavor digitar 2 numero mayores a 100");
           

            Console.WriteLine("");
            Console.Write("Dame el primer numero:");
            
            valor =  Console.ReadLine();
            nu1  =  Convert.ToSingle(valor);
            
            if(nu1<=99)
             Console.WriteLine("este numero no sirve reinicie el ejercicio");
            
            if (nu1>=100)
            Console.WriteLine("Continuemos");

            Console.Write("Dame el segundo numero:"); 

            valor =  Console.ReadLine();
            nu2  =  Convert.ToSingle(valor);
           
            if(nu2<=99)
             Console.WriteLine("este numero no sirve reinicie el ejercicio");

             if (nu2>=100)
            Console.WriteLine("Continuemos");

             Console.WriteLine("1.-  Suma"); 
            Console.WriteLine("2.-  Resta"); 
            Console.WriteLine("3.-  División"); 
            Console.WriteLine("4.-  Multiplicación");
            Console.WriteLine("");

            Console.Write("Que operación deseas realizar: "); 

            valor = Console.ReadLine();
            opcion   =  Convert.ToInt32(valor);

            if (opcion == 1)
                resultado =  nu1  +  nu2;
            if (opcion == 2)
                resultado =  nu1  - nu2;
            if (opcion == 3)
                if (nu2  !=  0) 
                    resultado =  nu1  / nu2;
                else 
                    Console.WriteLine("El divisor no sirve");
            if (opcion == 4)
                resultado =  nu1* nu2;
            Console.WriteLine("El resultado  de la operacion es:  {0}", resultado);
         
        }
    }
}
