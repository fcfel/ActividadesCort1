using System;

namespace _22_Apped
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] let = { 'h', 'o', 'l', 'a',':',')' };
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int inicio = Array.IndexOf(let, 'h');
            int fin = Array.IndexOf(let, ')');
            if (inicio >= 0 && fin >= 0)
            {
                sb.Append("El array de posicion ").Append(inicio).
                          Append(" a ").Append(fin).Append(" contiene ").
                          Append(let, inicio, fin + 1).Append(".");
                Console.WriteLine(sb);
            }
         
        }
    }
}
