namespace GenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDelegate = new MyDelegate<string>(Simple.PrintString);
            myDelegate += Simple.PrintUpperString;
            myDelegate.Invoke("Hi There");
        }
    }
    delegate void MyDelegate<T>(T value);
    class Simple
    {
        static public void PrintString(string s)
        {
            Console.WriteLine(s);
        }
        static public void PrintUpperString(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
}