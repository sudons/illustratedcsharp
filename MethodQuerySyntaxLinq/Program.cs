namespace MethodQuerySyntaxLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5,28, 31, 17, 16,42 };
            var numsQuery = from n in numbers where n < 20 select n;
            var numsMethod = numbers.Where( x=> x < 20);
            int numsCount = (from n in numbers where n<20 select n).Count();
            numbers[5] = 29;
            foreach (var x in numsQuery)
            {
                Console.Write($"{ x },");
            }
            Console.WriteLine();
            foreach (var x in numsMethod)
            {
                Console.Write($"{ x },");
            }
            Console.WriteLine();
            Console.WriteLine(numsCount);
        }
    }
}