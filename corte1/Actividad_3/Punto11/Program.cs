using System;
public class Problema_11
 {
   //trabajo realizado por: Felipe Cruz, Jeison Sastoque, Jesus De La Cruz, Wilson Gamba

     public static void Main(string[] args)
     { 
       int Genero;
       int salario2 = 0 ;
       int Tot1 = 0;
       int cc;
       int Tot2 = 0;
       int emp = 0;
       int lz = 0;
       int rr = 0;
       int salario = 0;
       Console.Write("Digite el numero de empleados ");
       emp = Convert.ToInt32(Console.ReadLine());

       for(int n = 0;  n < emp; n++)
      {
        Console.Write("Digite su numero de Cedula. ");
        cc = int.Parse(Console.ReadLine());

        Console.Write("Digite su genero (1=femenino y 2=masculino) ");
        Genero = int.Parse(Console.ReadLine());

       if (Genero == 1)
       {
       Console.Write("Digite su sueldo ");
       salario = int.Parse(Console.ReadLine());

       if (salario > 1000000)
        {
       Tot1= Tot1+ 1;
    
        }
      }
       lz=lz+salario;
       if (Genero == 2)
       {
        Console.Write("Digite su sueldo ");
       salario2 = int.Parse(Console.ReadLine());

        if (salario2 < 900000)
       {
       Tot2 = Tot2 + 1;
       } 
      }
        rr=rr+salario2;
     }
 
        //Resultado
       Console.WriteLine("Cantidad de mujeres que ganan mas de 1.000.000: "+Tot1);
       Console.WriteLine("Cantidad de hombres que ganan menos de 900.000: "+Tot2);
       Console.WriteLine("La suma de los sueldos de las mujeres es: "+lz);
       Console.WriteLine("La suma de los sueldos de los hombres es: "+rr);
    }
 }
