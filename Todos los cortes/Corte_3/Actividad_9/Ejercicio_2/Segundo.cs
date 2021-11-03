using System;
using System.Collections;
namespace Ejercicio_2
{
    class Segundo{
    int v,k;
      public Segundo(){
        Console.WriteLine (" DIGITE VALORES");
        Console.WriteLine ("Digite el primer valor");
        v= int.Parse (Console.ReadLine());
        Console.WriteLine ("Digite el segundo valor");
        k= int.Parse (Console.ReadLine());
      }
      int Suma (){
        int result= v+k;
        return result; 
      }
      int Resta(){
        int result= v-k;
        return result; 
      }
      int Multiplicacion(){
        int result= v*k;
        return result; 
      }
      
      int Division(){
        int result= v/k;
        return result; 
      }
    
        static void Main(string[] args){
        /*Grupo: Christian Felipe Cruz, Jeison Julian Sastoque, Jesus De La Cruz, Wilsom Camilo Gamba
        Realizado por: Jeison Julian Sastoque*/

        /* Ejercicio 2: Implementar la clase operaciones. Se deben cargar dos valores enteros en 
        el constructor, calcular su suma, resta, multiplicación y división, cada una en 
        un método, imprimir dichos resultados.*/
        Segundo sc= new Segundo();
        string opci;
        do{
        Console.WriteLine ("  MENÚ  ");
        Console.WriteLine ("1)Suma \n2)Resta \n3)Multiplicar \n4)Dividir \n5)Todos ");
        Console.WriteLine ("Elija una opcion: ");
        int op= int.Parse (Console.ReadLine());
        switch (op){
          case 1:
          Console.WriteLine ("  SUMA  ");
          Console.WriteLine ("El resultado de la suma es: ");
          Console.WriteLine (sc.Suma());           
           break;
          case 2:
          Console.WriteLine ("  RESTA  ");
          Console.WriteLine ("El resultado de la resta es: ");
          Console.WriteLine (sc.Resta());           
           break;
          case 3:
          Console.WriteLine ("  MULTIPLICACIÓN  ");
          Console.WriteLine ("El resultado de la multiplicacion es: ");
          Console.WriteLine (sc.Multiplicacion());           
           break;
          case 4:
          Console.WriteLine ("  DIVISION  ");
          Console.WriteLine ("El resultado de la division es: ");
          Console.WriteLine (sc.Division());           
           break;
          case 5:
          Console.WriteLine ("  TODOS  ");
          Console.WriteLine ("SUMA: ");
          Console.WriteLine ("El resultado de la suma es: ");
          Console.WriteLine (sc.Suma()); 
          Console.WriteLine ("RESTA: ");
          Console.WriteLine ("El resultado de la resta es: ");
          Console.WriteLine (sc.Resta()); 
          Console.WriteLine ("MULTIPLICACION: ");
          Console.WriteLine ("El resultado de la multiplicacion es: ");
          Console.WriteLine (sc.Multiplicacion());
          Console.WriteLine ("DIVISION:");
          Console.WriteLine ("El resultado de la division es: ");
          Console.WriteLine (sc.Division());               
          break;

          default:
          Console.WriteLine ("Esta opcion no esta dentro del sistema");       
          break;
        }
        Console.WriteLine ("¿Quieres intentarlo de nuevo (SI/NO)");
        opci= Console.ReadLine();
        }while (opci=="SI" || opci =="si");
        
        Console.ReadKey();
        Console.Clear();
        
        }  
    }
}
