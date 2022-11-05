using System.Drawing;

namespace HolderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intHolder = new Holder<int>(3, 5, 7);
            var stringHolder = new Holder<string>("hello", "ankium", "sudons");
            intHolder.Print();
            stringHolder.Print();
        }
    }
    static class ExtendHolder
    {
        public static void Print<T>(this Holder<T> h)
        {
            T[] vals = h.GetValues();
            Console.WriteLine($"{vals[0]},\t{vals[1]},\t{vals[2]}");
        }
    }
    class Holder<T>
    {
        T[] Vals = new T[3];
        public Holder(T v0,T v1,T v2)
        {
            Vals[0] = v0;
            Vals[1] = v1;
            Vals[2] = v2;
        }
        public T[] GetValues()
        {
            return Vals;
        }
    }
}