namespace GenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDelegate = new MyDelegate<string>(Simple.PrintUpperString);
            myDelegate.Invoke("Hi There");

            var myDel = new Func<int, int, string>(Simple.PrintString);
            Console.WriteLine($"Total:{myDel(13,15)}");
        }
    }
    public delegate void MyDelegate<T>(T value);
    public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);
    class Simple
    {
        static public void PrintUpperString(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        static public string PrintString(int p1,int p2)
        {
            int total = p1 + p2;
            return total.ToString();
        }
    }
}