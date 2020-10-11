using System;

namespace 實例103_使用加號運算子將兩個物件的屬性值相加
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 1 + 2;

            Test t1 = new Test { Val1 = 5, Val2 = 9 };
            Test t2 = new Test { Val1 = 2, Val2 = 6 };
            int result = t1 + t2;
            Console.WriteLine($"顯示屬性相加的結果{result}");

            Test NewTest = t1 * t2;
            Console.WriteLine($"顯示相乘NewTest的結果val1={NewTest.Val1} Val2={NewTest.Val2}");

        }
    }
    class Test
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }

        public static int operator +(Test a,Test b)
        {
            return a.Val1 + a.Val2 + b.Val1 + b.Val2;
        }

        public static Test operator *(Test a, Test b)
        {
            return new Test {
                            Val1 =a.Val1*b.Val1,
                            Val2 = a.Val2*b.Val2
                            };
        }
    }
}
