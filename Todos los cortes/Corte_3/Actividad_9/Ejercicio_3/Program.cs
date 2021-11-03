using System;

namespace Actividad_9
{
    class Socio
    {
        private string nombre;
        private int antiguedad;
        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }
        /*public Socio(string nom, int ant)
        {
           nombre=nom; 
           antiguedad=ant;
        }*/
        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public void setAntiguedad(int antiguedad)
        {
            this.antiguedad = antiguedad;

        }

        public string getNombre()
        {
            return this.nombre;
        }
        public int getAntiguedad()
        {
            return this.antiguedad;
        }

    }
    class Club
    {
        Socio socio1 = new Socio("Carlos", 24);
        Socio socio2 = new Socio("Andres", 2);
        Socio socio3 = new Socio("Juan", 18);

        public Socio mostrarMasAntiguo()
        {
            if (socio1.getAntiguedad() > socio2.getAntiguedad())
            {
                if (socio1.getAntiguedad() > socio3.getAntiguedad())
                {
                    return socio1;

                }
            }
            else
            {
                if (socio2.getAntiguedad() > socio3.getAntiguedad())
                {
                    return socio2;
                }

            }
            return socio3;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Club club1 = new Club();
            Socio socio1 = club1.mostrarMasAntiguo();
            Console.WriteLine("El socio mas antiguo es: "+socio1.getNombre()+" con "+socio1.getAntiguedad()+" años de antiguedad");


        }
    }
}