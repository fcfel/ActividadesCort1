using System;

namespace Punto_6
{
    class Program
    {
        /*
        Ejercicio N°6
        Grupo de trabajo: Christian Felipe Cruz Castrillon, Jeison Julian Sastoque Silva, Wilson Camilo Gamba Alvarez
        Realizado por: Jeison Julian Sastoque Silva
        */
        
            static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escribe el numero de alumnos a ingresar");
                int Estudiante = int.Parse(System.Console.ReadLine());
                double[] Estudiante_1 = new double[Estudiante];
                string[] Nestudiantes = new string[Estudiante];
                double[,] Not = new double[3, Estudiante];
                requestStudentNotes(Not,Estudiante);
                StudentAV(Not, Estudiante_1, Estudiante);
                showResults(Estudiante_1,Estudiante,Not);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("El valor ingresado debe ser un numero");
            }

        }
        static void requestStudentNotes(double[,] Not, int Estudiante)
        {
            for(int y = 0; y < Estudiante; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    try
                    {
                        Console.Write("Escribe la nota {0} del estudiante {1}: ", (x + 1), (y + 1));
                        Not[x,y] = int.Parse(System.Console.ReadLine());
                        Console.Write(" {0} \n", Not[x,y]);                         
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El valor ingresado debe ser un numero");
                        y--;    
                    }
                }
            }
        }
        static void StudentAV(double[,] Not, double[] Estudiante_1, int Estudiante)
        {
            for(int y = 0; y < Estudiante; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    Estudiante_1[y] += Not[x,y];
                }
                Estudiante_1[y] /= Estudiante;
            }
        }
        static double classAverage(double[,] Not, int Estudiante)
        {
            double ClassAV = 0; 
            for(int y = 0; y < Estudiante; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    ClassAV += Not[x,y];
                }
            }
            ClassAV /= Not.Length;
            return ClassAV;
        }
        static double maxStudentAverage(double[] Estudiante_1 , int Estudiante)
        {
            double maxAverage = 0;
            for(int y = 0; y < Estudiante ; y++)
            {
                if(Estudiante_1[y] > maxAverage)
                {
                    maxAverage = Estudiante_1[y];
                }
            }
            return maxAverage;
        }
        static void showResults(double[] Estudiante_1, int Estudiante, double[,] Not)
        {
            for(int x = 0 ; x < Estudiante_1.Length ; x++)
            {
                Console.Write("El promedio del estudiante {0} es: {1} \n", (x + 1), Estudiante_1[x]);
            }
            Console.WriteLine("El estudiante con mayor promedio es: {0}",maxStudentAverage(Estudiante_1, Estudiante));
            Console.WriteLine("la clase tiene un promedio de: {0}",classAverage(Not, Estudiante));
        }
       
        }

    }
    


