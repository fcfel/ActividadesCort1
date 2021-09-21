using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
             {
            /* Creado por: Felipe Cruz, Wilson Gamba, Jesus De La Cruz, Jeison Sastoque
            Grupo: 239-2A Bogotá
            Turno: Diurno
            */
            
            double resulAgua= 0;
            double resulGas =0;
            double resulLuz=0;
            double agua, gas, luz;
            double estrato;

            Console.WriteLine("Ingrese el valor del agua: ");
            agua = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del gas: ");
            gas = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del luz: ");
            luz = double.Parse(Console.ReadLine());

            System.Console.WriteLine("RECUERDE QUE EL ESTRATO VA 1,2,3,4,5, O 6");

            Console.Write("Ingrese su estrato: ");
            estrato = double.Parse(Console.ReadLine());

            switch (estrato)
            {
                case 1:
                resulAgua =agua*0.2;
                resulGas = gas*0.2;
                resulLuz = luz*0.2;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;
                break;

                case 2:
                 resulAgua =agua*0.15;
                resulGas = gas*0.15;
                resulLuz = luz*0.15;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;

                break;

                case 3:
                 resulAgua =agua*0.09;
                resulGas = gas*0.09;
                resulLuz = luz*0.09;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;

                break;
                case 4:
                 resulAgua =agua*0.09;
                resulGas = gas*0.09;
                resulLuz = luz*0.09;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;

                break;
                case 5:
                 resulAgua =agua*0.09;
                resulGas = gas*0.09;
                resulLuz = luz*0.09;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;

                break;
                case 6:
                 resulAgua =agua*0.09;
                resulGas = gas*0.09;
                resulLuz = luz*0.09;

                resulAgua =agua -resulAgua;
                resulGas = luz - resulGas;
                resulLuz = luz - resulLuz;

                break;

                  }
                System.Console.WriteLine("total a pagar de agua " + resulAgua);
                System.Console.WriteLine("total a pagar de luz " + resulLuz);
                System.Console.WriteLine("total a pagar de gas " + resulGas);
        }
        }
    }
}
