﻿using System;

namespace Actividad_9_Problema_1
{
    class Actividad_9_Problema_1
    {
        String[]Nombre;
        int[] Sueldo;
        int Cantidad;

        public Actividad_9_Problema_1()
        {
            Console.WriteLine("Ingrese el numero de empleados");
            Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            Nombre = new string[Cantidad];
            Sueldo = new int[Cantidad];

            for(int i=0;i<Cantidad;i++)
            {
                Console.WriteLine($"Ingrese el nombre del empleado {i+1}");
                Nombre[i] = Console.ReadLine();   
            }
            
            for (int f = 0; f <Cantidad; f++)
            {
             Console.WriteLine($"Ingrese el sueldo de {Nombre[f]}");
                Sueldo[f] = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");   
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("-------------------------------------");
            for(int i=0;i<Cantidad;i++)
            {
                Console.WriteLine($"{i+1}. Empleado {Nombre[i]} su sueldo es de {Sueldo[i]}.");
            }
            Console.WriteLine("------------------------");
        }

        public void Impuesto()
        {
            for(int i=0;i<Cantidad;i++)
            {
                if(Sueldo[i]>3000)
                {
                    Console.WriteLine($"El empleado {i + 1} {Nombre[i]} tiene que pagar impuestos y su sueldo fue mayor de 3000 fue de {Sueldo[i]}");
                }
            }
            Console.WriteLine("-----------------------");
        }

        static void Main(string[] args)
        {
            String WhileLoop = "";

            do
            {
                Console.WriteLine("Imprime los nombres y sueldos de los empleados e indica cual debe pagara impuesto");
                Console.WriteLine("----------------------------------------");

                Actividad_9_Problema_1 pv = new Actividad_9_Problema_1();
                pv.Imprimir();
                pv.Impuesto();
                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("------------------------");
            } while (WhileLoop == "s" || WhileLoop == "S");
            Console.WriteLine("Fin del programa :D");
        }
    }
}