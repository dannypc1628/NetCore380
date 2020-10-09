using System;

namespace 實例94_自訂特性類別
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OrderData o = new OrderData();
            o.OrdID = 123;
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Method)]
    public class MyDemoAttribute : Attribute
    {
        public string Description { get; set; }
    }

    public class OrderData
    {
        [MyDemo(Description = "訂單ID")]
        public int OrdID { get; set; }

        [MyDemo(Description = "增加時間")]
        public DateTime AddTime { get; set; }


        [MyDemo(Description = "計算折扣價")]
        public double Compute(double q)
        {
            return q * 0.98d;
        }
    }
}
