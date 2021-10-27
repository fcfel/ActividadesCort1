using System;
using System.Collections;

namespace _5_Equals
{
    class Program
    {
        bool b(string s1, string s2)
        {
            return true;
        }
        static void Main(string[] args)
        {
            int value1 = 12;
            int value2 = 12;

            object object1 = value1;
            object object2 = value2;

            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
                              object1, object1.GetType().Name,
                              object2, object2.GetType().Name,
                              object1.Equals(object2));
            byte v1 = 98;
            int v2 = 98;

            object obj1 = v1;
            object obj2 = v2;

            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
                              obj1, obj1.GetType().Name,
                              obj2, obj2.GetType().Name,
                              obj1.Equals(obj2));

        }

    }
}
