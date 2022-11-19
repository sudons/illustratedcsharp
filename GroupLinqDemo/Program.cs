namespace GroupLinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new {LName="Jones",FName="Mary",Age=19,Major="History"},
                new {LName="Smith",FName="Bob",Age=20,Major="CompSci"},
                new {LName="Fleming",FName="Carol",Age=21,Major="History"},
            };
            var query = from student in students
                        group student by student.Major;
            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
                foreach (var s in item)
                {
                    Console.WriteLine($"--------{s.LName}-{s.FName}-{s.Age}");
                }
            }
        }
    }
}