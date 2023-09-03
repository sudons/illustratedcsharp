using System;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "ankium";
            person.Level = Level.Boss;
            person.Skill = Skill.Drive | Skill.Cook | Skill.Program | Skill.Teach;
            Console.WriteLine(person.Skill);
            Console.WriteLine((person.Skill & Skill.Drive)==Skill.Drive);


        }
    }

    enum Level
    {
        Employee=100,
        Manager,
        Boss,
        BigBoss
    }

    enum Skill
    {
        Drive=1,
        Cook=2,
        Program=4,
        Teach=8
    }
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }
}