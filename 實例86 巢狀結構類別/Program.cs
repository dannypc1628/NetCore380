using System;

namespace 實例86_巢狀結構類別
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TheOut obj1 = new TheOut();
            obj1.CallNest();
            TheOut.TheNest obj2 = new TheOut.TheNest();
            obj1.NestObj = obj2;

            obj1.CallNest();
        }
    }

    public class TheOut
    {
        public TheNest NestObj { get; set; }

        public void CallNest()
        {
            if (NestObj != null)
            {
                NestObj.CallMe();
            }
            else
            {
                Console.WriteLine("沒有NestObj實體");
            }
        }
        public class TheNest
        {
            public void CallMe() => Console.WriteLine("正在存取巢狀結構的類別實例");
        }
    }
}
