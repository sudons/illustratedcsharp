using System;
using System.Threading;

namespace SyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new ManualResetEvent(false);
            new Thread(()=>{
                System.Console.WriteLine("Waiting for signal...");
                signal.WaitOne();
                signal.Dispose();
                System.Console.WriteLine("Got signal!");
            }).Start();
            Thread.Sleep(3000);
            signal.Set();
        }     
    }
}
