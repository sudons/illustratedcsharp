using System;
using System.Collections.Generic;

namespace NetStandardLib
{
    public class Utils
    {
        public static void PrintAssemblyNames()
        {
            Console.WriteLine(typeof(Dictionary<,>).Assembly.FullName);
            Console.WriteLine(typeof(SortedDictionary<,>).Assembly.FullName);
        }
    }
}
