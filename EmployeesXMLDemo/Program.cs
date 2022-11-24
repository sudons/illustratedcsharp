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
                new XDeclaration("1.0","utf-8","yes"),
                new XComment("This is a comment"),
                new XProcessingInstruction("xml-stylesheet",@"href=""stories.css"",type=""text/css"""),
                new XElement("Employees",
                    new XAttribute("color", "red"),
                    new XAttribute("size", "large"),
                    new XElement("Employee",
                        new XElement("Age","32"),
                        new XElement("Name", "云文"),
                        new XElement("PhoneNumber", "15083829025")),
                    new XElement("Employee",
                        new XElement("Age","33"),
                        new XElement("Name", "胡翌瑄"),
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
                        new XElement("Age","10"),
                        new XElement("Name", "云杉"),
                        new XElement("PhoneNumber", "18800000000")
                        )
                );
            //显示修改后的XML树
            Console.WriteLine("-----------修改树-----------");
            ShowElement(employees, "Name", "PhoneNumber");

            //显示XML文档内容
            Console.WriteLine("-----------文档源-----------");
            Console.WriteLine(employeeDoc);

            //查看节点特性
            Console.WriteLine("-----------获取节点特性-----------");
            Console.WriteLine($"color is {root.Attribute("color").Value},size is {root.Attribute("size").Value}");

            //移除节点属于
            root.Attribute("color").Remove();
            root.SetAttributeValue("size", null);

            //添加或者改变节点特性
            root.SetAttributeValue("size", "small");
            root.SetAttributeValue("width", "narrow");

            //显示XML文档内容
            Console.WriteLine("-----------文档源-----------");
            Console.WriteLine(employeeDoc);

            //LINQ TO XML的LINQ查询
            Console.WriteLine("-----------LINQ TO XML和LINQ查询表达式的组合使用-----------");
            IEnumerable<XElement> xyz = from e in employees
                                        where e.Name.ToString().Length == 8
                                        select e;

            foreach (XElement x in xyz)
            {
                x.SetAttributeValue("LikeColor", "green");
                Console.WriteLine(x);
            }

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