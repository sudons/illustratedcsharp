using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace NetStandardLib
{
    public class Utils
    {
        public static void PrintAssemblyNames()
        {
            Console.WriteLine(typeof(Dictionary<,>).Assembly.FullName);
            Console.WriteLine(typeof(SortedDictionary<,>).Assembly.FullName);
            Console.WriteLine(typeof(Task).Assembly.FullName);
            Console.WriteLine(typeof(Uri).Assembly.FullName);
            Console.WriteLine(typeof(XmlWriter).Assembly.FullName);
        }
    }
}
