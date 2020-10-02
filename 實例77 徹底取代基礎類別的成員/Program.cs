using System;

namespace 實例77_徹底取代基礎類別的成員
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CheckTask t1 = new CheckTask();
            t1.Run(15);

            DRCheckTask t2 = new DRCheckTask();
            t2.Run(10);
        }
    }

    class CheckTask
    {
        public void Run(int max)
        {
            Console.WriteLine("最大執行工作數：{0}", max);
        }
    }
    class DRCheckTask : CheckTask
    {

        public new void Run(int count)
        {
            Console.WriteLine("平行工作數:{0}",count);            
        }
    }
}
