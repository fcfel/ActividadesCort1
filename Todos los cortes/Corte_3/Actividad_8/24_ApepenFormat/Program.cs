using System;
using System.Text;
using System.Globalization;

class Sample
{
    static StringBuilder sb = new StringBuilder();

    public static void Main()
    {
    int    a   = 17;
    float  b  = 2.22F;
    string c  = "hola soy Felipe";
    object[] d = {3, 4.4, 'F'};

    Console.WriteLine();
    Console.WriteLine("Resultado: ");
    sb.AppendFormat("1) {0}", a);
    Show(sb);
    sb.AppendFormat("2) edad {0}, {1} mi promedio", a, b);
    Show(sb);
    sb.AppendFormat("3) edad {0}, {1} mi promedio, {2} ", a, b, c);
    Show(sb);
    sb.AppendFormat("4) {0}, {1}, {2}", d);
    Show(sb);
    CultureInfo ci = new CultureInfo("es-ES", true);
    sb.AppendFormat(ci, "5) perdi {0}", b);
    Show(sb);
    }

    public static void Show(StringBuilder sbs)
    {
    Console.WriteLine(sbs.ToString());
    sb.Length = 0;
    }
}
/*
This example produces the following results:

StringBuilder.AppendFormat method:
1) 111
2) 111, 2.22
3) 111, 2.22, abcd
4) 3, 4.4, X
5) 2,22
*/
