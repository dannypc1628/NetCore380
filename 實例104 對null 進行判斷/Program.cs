using System;

namespace 實例104_對null_進行判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A a = new A();

            a?.Work();

            Console.WriteLine("接下來執行p");
            A p = null;
            //直接p.Work();會發生Null Reference Exception: 
            //Object reference not set to an instance of an object
            
            p?.Work();//同下
            if (p != null)
            {
                p.Work();
            }
        }

        class A
        {
            public void Work() => Console.WriteLine("{0}這個方法被呼叫", nameof(Work));
        }
    }
}
