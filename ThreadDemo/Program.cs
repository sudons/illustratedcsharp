using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("异步方法启动{0}",Thread.CurrentThread.ManagedThreadId);
            //.NET Framework 1.0-1.1
            // ThreadStart threadStart = () => {
            //     System.Console.WriteLine($"This is thread start {Thread.CurrentThread.ManagedThreadId}");
            //     Thread.Sleep(2000);
            //     System.Console.WriteLine($"This is thread end {Thread.CurrentThread.ManagedThreadId}");
            // };
            // Thread thread = new Thread(threadStart);
            // thread.Start();
            
            //.NET Framework 2.0
            // WaitCallback waitCallback = wait=>{
            //     System.Console.WriteLine($"This is thread start {Thread.CurrentThread.ManagedThreadId}");
            //     Thread.Sleep(2000);
            //     System.Console.WriteLine($"This is thread end {Thread.CurrentThread.ManagedThreadId}");
            // };
            // ThreadPool.QueueUserWorkItem(waitCallback);

            //.NET Framework 3.0
            // Action action = ()=>{
            //     System.Console.WriteLine($"This is thread start {Thread.CurrentThread.ManagedThreadId}");
            //     Thread.Sleep(2000);
            //     System.Console.WriteLine($"This is thread end {Thread.CurrentThread.ManagedThreadId}");
            // };
            // Task task = new Task(action);
            // task.Start();

            //.NET Framework 4.0
            Action actionA = ()=>{
                System.Console.WriteLine($"This is thread 1 start {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
                System.Console.WriteLine($"This is thread 1 end {Thread.CurrentThread.ManagedThreadId}");
            };
            Action actionB = ()=>{
                System.Console.WriteLine($"This is thread 2 start {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
                System.Console.WriteLine($"This is thread 2 end {Thread.CurrentThread.ManagedThreadId}");
            };
            Action actionC = ()=>{
                System.Console.WriteLine($"This is thread 3 start {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
                System.Console.WriteLine($"This is thread 3 end {Thread.CurrentThread.ManagedThreadId}");
            };
            Parallel.Invoke(actionA,actionB,actionC);

            System.Console.WriteLine("异步方法结束{0}",Thread.CurrentThread.ManagedThreadId);
        }
    }
}
