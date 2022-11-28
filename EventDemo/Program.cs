namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer= new Incrementer();
            Dozens dozensCounter = new Dozens(incrementer);
            incrementer.DoCount();
            Console.WriteLine($"Number of dozens={dozensCounter.DozensCount}");
        }
    }
    //自定义事件参数
    class IncrementerEventArgs : EventArgs
    {
        public int IterationCount { get; set; }
    }
    //事件发布者
    class Incrementer
    {
        //事件
        public event EventHandler<IncrementerEventArgs> CountedADozen;
        //触发事件
        public void DoCount()
        {
            IncrementerEventArgs args = new IncrementerEventArgs();
            for (int i = 1; i < 100; i++)
            {

                if (i%12==0&&CountedADozen!=null)
                {
                    args.IterationCount = i;
                    CountedADozen(this, args);
                }
            }
        }
    }
    //事件订阅者
    class Dozens
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            //订阅事件
            incrementer.CountedADozen += IncrementDozensCount;
        }

        //事件处理程序
        void IncrementDozensCount(object? sender, IncrementerEventArgs e)
        {
            Console.WriteLine($"Incremented at iteration:{ e.IterationCount }int{ sender.ToString()}");
            DozensCount++;
        }
    }
}