using System;

namespace 實例76_重新定義基礎類別的成員
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyTest t = new MyTest();
            t.Outupt();
        }
    }

    class MyBase
    {
        public virtual void Outupt()
        {
            Console.WriteLine("基礎類別的方法被呼叫");
        }
    }

    class MyTest : MyBase
    {
        public override void Outupt()
        {
            Console.WriteLine("衍生類別的方法被呼叫");
            base.Outupt();
        }
    }
}
