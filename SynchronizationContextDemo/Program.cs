using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationContextDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main异步演示开始~~~~~");
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Task> tasks = new List<Task>
            {
                Bash(),//洗澡
            };
            tasks.Add(BreakFast());//吃早餐
            tasks.Add(WashClothes());//洗衣服
            tasks.Add(WriteArticle());//写文章
            tasks.Add(WritingCode());//写代码
            await Task.WhenAll(tasks);
            Console.WriteLine("Main异步演示结束~~~~~共用时{0}秒！", stopwatch.ElapsedMilliseconds / 1000);
            Console.ReadKey();
        }

        private static async Task Bash()
        {
            Console.WriteLine("洗澡开始~~~~~");
            await Task.Delay(1 * 1000);//模拟过程
            Console.WriteLine("洗澡结束~~~~~");
        }

        private static async Task BreakFast()
        {
            Console.WriteLine("吃早餐开始~~~~~");
            await Task.Delay(1 * 1000);//模拟过程
            Console.WriteLine("吃早餐结束~~~~~");
        }

        private static async Task WashClothes()
        {
            Console.WriteLine("洗衣服开始~~~~~");
            await Task.Delay(6 * 1000);//模拟过程
            Console.WriteLine("洗衣服结束~~~~~");

        }

        private static async Task WriteArticle()
        {
            Console.WriteLine("写文章开始~~~~~");
            await Task.Delay(20 * 1000);//模拟过程
            Console.WriteLine("写文章结束~~~~~");
        }

        private static async Task WritingCode()
        {
            Console.WriteLine("写代码开始~~~~~");
            await Task.Delay(12 * 1000);//模拟过程
            Console.WriteLine("写代码结束~~~~~");
        }

    }
}
