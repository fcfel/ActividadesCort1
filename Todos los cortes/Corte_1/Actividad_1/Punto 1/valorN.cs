using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Creado por: Felipe Cruz
 * Grupo: 239-2A
 * Turno: Diurno 
*/

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 < 0)
                  Console.Write("El numero es: " + num1 + " y su valor absoluto es: "+ Math.Abs(num1));
            else
                  Console.Write("El numero es: "+ num1);

            Console.ReadKey();      

        }
    }
}
