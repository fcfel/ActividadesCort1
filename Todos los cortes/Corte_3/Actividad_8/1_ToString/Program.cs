
using System;

public class Automobile
{
   private int _espacio;
   private string _modelo;
   private int _año;
   private string _marca;
   private double _precio;

   public Automobile(string model, int year , int doors, double precio,
                     string modelo)
   {
      _marca= model;
      _año = year;
      _espacio = doors;
      _modelo = modelo;
      _precio = precio;
   }

   public int Doors
   { get { return _espacio; } }

   public string Model
   { get { return _marca; } }

   public int Year
   { get { return _año; } }

   public string Modelo
   { get { return _modelo; } }
   public double precio
   {get { return _precio; } }

   public string ToString(string opc)
   { 
      
      do
      {
      System.Console.WriteLine("A- Ver el año de lanzamiento del celular ");
      System.Console.WriteLine("B- Ver marca del celular ");
      System.Console.WriteLine("C- Ver espacio interno del celular ");
      System.Console.WriteLine("D- modelo");
      System.Console.WriteLine("E- resumen");
      System.Console.WriteLine("");
      System.Console.WriteLine("¿Que seas saber de tu proximo celular en promocion?");
      opc=Console.ReadLine();
      

      switch (opc.ToUpperInvariant())
      {
         
         case "A":
            return string.Format("{0} ", _año);
         case "B":
            return string.Format("{0} ", _marca);
         case "C":
            return string.Format("{0} GB. ",_espacio);
            case "D":
            return string.Format("{0}",_modelo);
         case "E":
            return string.Format("{0}, {1}, {2} GB. precio: {3} modelo {4} ",
                                 _año, _marca, _espacio, _precio,_modelo);
         default:

         return string.Format("Letra invalida");
      } 
      } while (opc!="p"); 
   }
}

public class Example
{
   public static void Main()
   {
     
      var celular = new Automobile("Huawei", 2021, 128, 700000, "P40 Pro");
      System.Console.WriteLine(celular.ToString(""));
      
    
   }
}
