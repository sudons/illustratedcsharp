using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AnonymousType
{
    class Program
    {
        static bool IsBool(int a)
        {
            return a % 2 == 1;
        }
        
        static void Main()
        {
            XDocument employeeDoc =
                new XDocument(
                    new XElement("Employees",
                        new XElement("Employee",
                            new XElement("Name", "Bob Smith"),
                            new XElement("PhoneNumber", "408-555-1000")
                            ),
                        new XElement("Employee",
                            new XElement("Name", "Sally Jones"),
                            new XElement("PhoneNumber", "415-555-2000"),
                            new XElement("PhoneNumber", "415-555-2001")
                            )
                        )
                    );
            //获取第一个名为"Employees"的子XElement
            XElement root = employeeDoc.Element("Employees");
            IEnumerable<XElement> employees = root.Elements();

            foreach (XElement emp in employees)
            {
                //获取第一个名为"Name"的子XElement
                XElement empNameNode = emp.Element("Name");
                Console.WriteLine(empNameNode.Value);
                //获取所有名为"PhoneNumber"的子元素
                IEnumerable<XElement> empPhones = emp.Elements("PhoneNumber");
                foreach (XElement phone in empPhones)
                    Console.WriteLine(" {0}", phone.Value);
            }
            
            int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };
            var countOdd = Enumerable.Count(intArray, IsBool);
            //var countOdd = intArray.Count(n => n % 2 == 1);
            //寻找奇数的Lambda表达式
            Console.WriteLine("Count of odd numbers: {0}", countOdd);
            
            var students = new[]
            {
                new {LName = "Jones", FName = "Mary", Age = 19, Major = "History"},
                new {LName = "Smith", FName = "Bob", Age = 20, Major = "CompSci"},
                new {LName = "Fleming", FName = "Carol", Age = 21, Major = "History"}
            };
            var query = from student in students group student by student.Major;
            foreach (var q in query)
            {
                Console.WriteLine($"{q.Key}");
                foreach (var t in q) Console.WriteLine($"-----{t.FName} {t.LName} {t.Age}");
            }

            var groupA = new[] {3, 4, 5, 6};
            var groupB = new[] {4, 5, 6, 7};
            var someInts = from a in groupA
                join b in groupB on a equals b
                    into groupC
                from c in groupC
                select c;
            foreach (var a in someInts)
                Console.Write("{0} ", a);
        }
    }
}