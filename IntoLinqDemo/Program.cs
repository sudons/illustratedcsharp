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

            Console.WriteLine("++++++++++++++++++++");
            int[] intArray = new int[] { 3,4,5,6,7,9 };
            var count1 = Enumerable.Count(intArray);
            var firstNum1 = Enumerable.First(intArray);

            var count2 = intArray.Count();
            var firstNum2 = intArray.First();

            Console.WriteLine($"Count:{count1},firstNumber:{firstNum1}");
            Console.WriteLine($"Count:{count2},firstNumber:{firstNum2}");

        }
    }
}