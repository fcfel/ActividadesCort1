using System;

namespace Punto_10
{
    class Program
    {
        static void Main(string[] args)

        {
            // variables
            string clave,nombre;
            

            Console.WriteLine("Ingrese su nombre");
            nombre=Console.ReadLine();

            // ciclo repetitivo para preguntar por la contraseña en caso que este incorrecta

             do
            {

                System.Console.WriteLine("Ingrese la contraseña");
                clave=Console.ReadLine();

            } while (clave!="iloveyou123");{

            System.Console.WriteLine("Bienvenido " + nombre);

           }
        }
    }
}
