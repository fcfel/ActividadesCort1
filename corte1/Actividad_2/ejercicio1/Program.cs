using System;

namespace Problema1
{
    class Client
    {

        static void Main(string[] args)
        {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */

            
            String[] materias = {"Matemáticas", "Español", "Inglés", "Física"};
            String[] nombres = new String[5];
            int[,] calificaciones = new int[5, 4]; 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                String nombre;
                nombre = Console.ReadLine();
                nombres[i] = nombre;
                for (int j = 0; j < 4; j++)
                {
                    Boolean siguiente = false;
                    while (siguiente == false)
                    {
                        Console.WriteLine("Digite la calificación de la materia " + materias[j]);
                        int calif;
                        calif = int.Parse(Console.ReadLine());
                        calificaciones[i, j] = calif;
                        if (calif < 0 || calif > 100)
                        {
                            Console.WriteLine("La calificación debe ser entre 0 y 100");
                            Console.WriteLine();
                        }
                        else{
                            siguiente = true;
                        }
                    }
                }
            }
            imprimirReporte(nombres, calificaciones);

        }

        public static void imprimirReporte(String[] nombres, int[,] calificaciones){
            String[] materias = {"Matemáticas", "Español", "Inglés", "Física"};
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Estudiante: " + nombres[i]);
                for (int j = 0; j < 4; j++)
                {
                    String clasificacion;
                    if(calificaciones[i, j] < 50){
                        clasificacion = "Insuficiente";
                    }else if(calificaciones[i, j] < 70){
                        clasificacion = "Suficiente";
                    }else if(calificaciones[i, j] < 80){
                        clasificacion = "Bien";
                    }else if(calificaciones[i, j] < 90){
                        clasificacion = "Notable";
                    }else{
                        clasificacion = "Sobresaliente";
                    }
                    Console.WriteLine("Nota de " + materias[j] + ": " + calificaciones[i, j] + " - " + clasificacion);
                }
            }
        }

    }
}