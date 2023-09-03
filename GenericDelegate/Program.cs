using System;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> a1 = Say;
            a1("ankium");
            Action<int> a2 = Mul;
            a2.Invoke(3);

            Func<double, double, double> f1 = Add;
            var result = f1.Invoke(100.1, 200.2);
            Console.WriteLine(result);

            Func<double, double, double> f2 = (a, b) => { return a + b; };
            var res = f2.Invoke(100.1, 200.2);
            Console.WriteLine(res);
            
        }

        static void Say(string str)
        {
            Console.WriteLine($"Hello,{str}");
        }

        static void Mul(int x)
        {
            Console.WriteLine(x*100);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}