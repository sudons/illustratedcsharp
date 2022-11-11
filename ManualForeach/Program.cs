using System.Collections;

namespace ManualForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[]
            {
                10,11,12,13
            };
            IEnumerator ie = intArr.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine((int)ie.Current);
            }
        }
    }
}