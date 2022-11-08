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
}