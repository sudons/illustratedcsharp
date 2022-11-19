namespace IntoLinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 3, 4, 5, 6 };
            var groupB = new[] { 4,5,6,7 };
            var someInts = from a in groupA
                           join b in groupB
                           on a equals b
                           into groupAandB
                           from c in groupAandB
                           select c;
            foreach (var item in someInts)
            {
                Console.WriteLine(item);
            }

        }
    }
}