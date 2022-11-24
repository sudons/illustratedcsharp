using System.Xml.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace EmployeesXMLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument employeeDoc = new XDocument(
                new XElement("Employees",
                    new XElement("Employee",
                        new XElement("Name", "云文"),
                        new XElement("PhoneNumber", "15083829025")),
                    new XElement("Employee",
                        new XElement("Name", "小胡"),
                        new XElement("PhoneNumber", "13891182640"),
                        new XElement("PhoneNumber", "13891182645"))
                )
            );
            //获取第一个名为"Employees"的子XElement
            XElement root = employeeDoc.Element("Employees");

            IEnumerable<XElement> employees = root.Elements();

            //显示原始XML树
            Console.WriteLine("-----------原始树-----------");
            ShowElement(employees, "Name", "PhoneNumber");

            //向XML树中增加节点
            root.AddFirst(new XElement("Employee",
                        new XElement("Name", "云杉"),
                        new XElement("PhoneNumber", "18800000000")
                        )
                );
            //显示修改后的XML树
            Console.WriteLine("-----------修改树-----------");
            ShowElement(employees, "Name", "PhoneNumber");

        }
        public static void ShowElement(IEnumerable<XElement> xElement,string name,string phoneNumber)
        {
            foreach (XElement emp in xElement)
            {
                //获取第一个名为"Name"的子XElement
                XElement empNameNode = emp.Element(name);
                Console.WriteLine(empNameNode.Value);

                //获取所有名为"PhoneNumber"的子元素
                IEnumerable<XElement> empPhones = emp.Elements(phoneNumber);
                foreach (XElement phone in empPhones)
                {
                    Console.WriteLine($"   {phone.Value}");
                }
            }
        }
    }
}