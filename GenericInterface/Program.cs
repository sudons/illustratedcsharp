namespace GenericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trivInt = new Simple<int>();
            var trivString = new Simple<string>();
            Console.WriteLine($"{trivInt.ReturnIt(5)}");
            Console.WriteLine($"{trivString.ReturnIt("Hi There.")}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Simple trivial = new Simple();
            Console.WriteLine($"{trivial.ReturnIt(5)}");
            Console.WriteLine($"{trivial.ReturnIt("Hi There.")}");
        }
    }
    interface IMyInterface<T>
    {
        T ReturnIt(T inValue);
    }
    class Simple<S> : IMyInterface<S>
    {
        public S ReturnIt(S inValue)
        {
            return inValue;
        }
    }
    class Simple : IMyInterface<int>, IMyInterface<string>
    {
        public int ReturnIt(int inValue)
        {
            return inValue;
        }
        public string ReturnIt(string inValue)
        {
            return inValue;
        }
    }
}