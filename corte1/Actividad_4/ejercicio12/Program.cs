using System;

namespace ejrcicio12
{
    
     
    class Program
    {   
        static void Main(string[] args)
        {
            /*Creado por: Felipe cruz
            grupo de trabajo: Jeison Sastoque, Jesus de la Cruz, Wilson Gamba*/

         int a; 
         string desea1="";
         string [] m;
         m = new string[12];
         m[0]= "Enero";
         m[1]= "Febrero";
         m[2]= "Marzo";
         m[3]= "Abril";
         m[4]= "Mayo";
         m[5]= "Junio";
         m[6]= "Julio";
         m[7]= "Agosto";
         m[8]= "Septiembre";
         m[9]= "Ocutubre";
         m[10]= "Noviembre";
         m[11]= "Diciembre";
         do
         {
             
        
         Console.WriteLine("¡Bienvenido al su calendario!");
            System.Console.WriteLine("Ingrese el año");
            a=int.Parse(Console.ReadLine());
          
            

         for (int Mes = 1; Mes <=12; Mes++)
     {
         System.Console.Write("\n");
         System.Console.WriteLine("Mes : "+m[Mes-1]);
         System.Console.WriteLine("Dom Lun Mar Mie Jue Vie Sab");

         int x =zeller(a,Mes,1);

         for (int i = 0; i < x; i++)
         {
             System.Console.Write("    ");
         }

        int dias_mes_actual= CalcularDias(Mes,a);

         for (int dia = 1; dia <=dias_mes_actual; dia++)
         {
             if (dia< 10) 
             {
              System.Console.Write(dia+"   ");   
             }else{
                 System.Console.Write(dia+"  ");
             }
             x++;
             if (x % 7==0)
             {
                 System.Console.Write("\n");
             }
         }
     }
     System.Console.WriteLine("");
     
       System.Console.WriteLine("\n¿Que planeas hacer?");
       string plan= Console.ReadLine();
       System.Console.WriteLine("");
       System.Console.WriteLine("\nEn que mes deseas hacerlo");
       int M=int.Parse(Console.ReadLine());
       
       System.Console.WriteLine("");
       System.Console.WriteLine("\n ¿Que dia?");
       int dia1= int.Parse(Console.ReadLine());
       System.Console.WriteLine("\n ¿A que horas inicia (formato 24 horas)?");
       int hora=int.Parse(Console.ReadLine());
       
       System.Console.WriteLine("\n Se acaba de agregar un nuevo evento ");
       
       System.Console.Write("Ud agrego un evento para el año: " + a );
       System.Console.Write(" Su evento es: "+plan);
if (M==1)
       {
           System.Console.Write(" inicia en el mes de Enero ");
       }
       if (M==2)
       {
           System.Console.Write(" inicia en el mes de Febrero");
       }
       if (M==3)
       {
           System.Console.Write(" inicia en el mes de Marzo");
       }
       if (M==4)
       {
           System.Console.Write(" inicia en el mes de Abril");
       }
       if (M==5)
       {
           System.Console.Write(" inicia en el mes de Mayo");
       }
       if (M==6)
       {
           System.Console.Write(" inicia en el mes de Junio");
       }
       if (M==7)
       {
           System.Console.Write(" inicia en el mes de Julio");
       }
       if (M==8)
       {
           System.Console.Write(" inicia en el mes de Agosto");
       }
       if (M==9)
       {
           System.Console.Write(" inicia en el mes de Septiembre");
       }
       if (M==10)
       {System.Console.Write(" inicia en el mes de Octubre");
           
       }
       if (M==11)
       {
           System.Console.Write(" inicia en el mes de Noviembre");
       }
       if (M==12)
       {
           System.Console.Write(" inicia en el mes de Diciembre");
       }
       System.Console.Write(" el dia "+ dia1);
       System.Console.Write(" a las " + hora);
          
       System.Console.WriteLine("\n¿Desea agregar otra evento s/n?");
       desea1=Console.ReadLine();

        } while (desea1!="n");

        }
        
public static int CalcularDias(int Mes,int a){
if (Mes==1 || Mes==3 || Mes==5 || Mes==7 ||Mes==8 ||Mes==10 ||Mes==12 )
{
    return 31;
}
if (Mes==2)
{
    if (Bisiesto(a) == true) 
    {
        return 29;
    }else return 28;
}
return 30;
 }
public static bool Bisiesto(int a){
    if (a%4 !=0)
    {
        return false;
    }else if (a%100 !=0)
    {
        return true;
    }else if (a%400 !=0)
    {
       
    }
     return false;
}
public static int zeller(int ano, int Mes, int dia){
    int año=(14-Mes)/12;
    int y= ano-año;
    int m=Mes+12*año -2;
    int d =(dia +y +y/4 -y/100 +y/400 +(31*m)/12)%7;
    return d;


     }
       }
          }
          
       
 



