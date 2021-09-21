using System;

namespace ejercicio4{


public class SumaMediaArrayApp {
 
    public static void Main(String[] args) {

        int[] numeros=new int[100];

        int suma=0;
        double media;

        for(int i=0;i<numeros.Length;i++)
        {
            numeros[i]=i+1;
            suma+=numeros[i];
        }

        System.Console.WriteLine("La suma es "+suma);
         
        media=(double)suma/numeros.Length;
         
        System.Console.WriteLine("La media es "+media);
         
    }
     
}
 }