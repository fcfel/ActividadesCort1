using System;


namespace punto5
{
    class Program
    {

    static void Main(string[]args)
    {
        /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */

int FechaAntiguaMes, FechaAntiguaAño, FechaAntiguaDia;
            int ActualMes, ActualAño,ActualDia;
            System.Console.WriteLine("Digite la fecha actual");
            System.Console.WriteLine("");

            System.Console.WriteLine("Ingrese Año");
            ActualAño=int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese Mes");
            ActualMes=int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese Dia");
            ActualDia=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese una fecha antigua.");
            Console.WriteLine("");
            Console.WriteLine("Digite Año:");
            FechaAntiguaAño = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite Mes:");
            FechaAntiguaMes = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite Dia:");
            FechaAntiguaDia = int.Parse(System.Console.ReadLine());

            ActualAño = ActualAño - FechaAntiguaAño;

            ActualMes = ActualMes - FechaAntiguaMes;

            ActualDia = ActualDia - FechaAntiguaDia;

            Console.WriteLine($"Actualmente han pasado {ActualAño} Año/s, {ActualMes} Mes/es, {ActualDia} Dia/s.");
        }
    }
}