using System;

namespace MyDelegateDemo
{
    delegate void MyDel(int value);//声明委托类型
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            MyDel myDel;//声明委托变量
            //创建随机整数生成器对象，并得到0到99之间的壹个随机数
            Random rand = new Random();
            int randomValue = rand.Next(99);
            //创建壹个包含PrintLow或PrintHign的委托对象并将其赋值给myDel变量
            myDel = randomValue < 50 ? new MyDel(program.PrintLow) : new MyDel(program.PrintHigh);
            myDel(randomValue);
        }
        void PrintLow(int value)
        {
            Console.WriteLine("{0} - Low Value", value);
        }
        void PrintHigh(int value)
        {
            Console.WriteLine("{0} - High Value", value);
        }
    }
}
