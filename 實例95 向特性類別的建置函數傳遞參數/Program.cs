using System;

namespace 實例95_向特性類別的建置函數傳遞參數
{
    [Limited(3, 6, BaseNum = 777)]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    [DoubleRange(700d)]
    public class Test
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class DoubleRangeAttribute : Attribute
    {
        public double Largest { get; }

        public DoubleRangeAttribute(double largest)
        {
            Largest = largest;
        }

    }



    [AttributeUsage(AttributeTargets.Class)]
    class LimitedAttribute : Attribute
    {
        int _min, _max;

        public LimitedAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public int BaseNum { get; set; }
    }
}
