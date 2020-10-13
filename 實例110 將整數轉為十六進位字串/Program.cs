using System;

namespace 實例110_將整數轉為十六進位字串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 91545588;
            Console.WriteLine("{0}-> Ox{1}",x,x.ToString("x2"));
            Console.WriteLine("{0}-> Ox{1}", x, x.ToString("u"));

        }
    }
}
