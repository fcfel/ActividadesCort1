using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] formats = { "yyyyMMdd", "HHmmss" };
            string[] dateStrings = { "20130816", "20131608", "  20130816   ",
                   "115216", "521116", "  115216  " };
            DateTime parsedDate;

            foreach (var dateString in dateStrings)
            {
                if (DateTime.TryParseExact(dateString, formats, null,
                                           System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                           System.Globalization.DateTimeStyles.AdjustToUniversal,
                                           out parsedDate))
                    Console.WriteLine($"{dateString} --> {parsedDate:g}");
                else
                    Console.WriteLine($" No se puede convertir {dateString}");
            }
        }
    }
}
