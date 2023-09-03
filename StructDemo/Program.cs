using System;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(){ID = 101,Name = "ankium"};
            object obj = student;
            Student stu1 = (Student) obj;
            Console.WriteLine($"#{stu1.ID} Name:{stu1.Name}");

            Student stu2 = stu1;
            stu2.ID = 1001;
            stu2.Name = "sudons";
            Console.WriteLine($"#{stu1.ID} Name:{stu1.Name}");

            Console.WriteLine($"#{stu2.ID} Name:{stu2.Name}");
            
            Student stu3 = new Student(201,"Termius");
            stu3.Speak();
        }
    }

    interface ISpeak
    {
        void Speak();
    }
    struct Student:ISpeak //结构体只能派生自基接口，不能派生自基类和基结构体
    {
        public Student(int id,string name) //结构体不能有显式无参构造器，但可以有显式有参构造器
        {
            this.ID = id;
            this.Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"I'm #{this.ID} Name:{this.Name}");
        }
    }
}