using System;

namespace DelegateCaptured
{
    delegate void MyDel();
    class Program
    {
        static void Main(string[] args)
        {
            MyDel myDel;
            {
                int x = 5;
                myDel = delegate
                {
                    System.Console.WriteLine("Value of x:{0}", x);
                };
            }
            //System.Console.WriteLine("Value of x:{0}", x);
            if (null != myDel)
            {
                myDel();
            }
        }
    }
}
