using System;

namespace 實例60_多載方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Play(1);

            Play(123.0f);

            WorkAs("abc", 3);
            WorkAs("BBB");
            WorkAs();

            Test t = new Test();
            int r1 = t.Compute(5);
            int r2 = t.Compute(5, 5);
            int r3 = t.Compute(5, 5, 5);

            Console.WriteLine("三個計算結果分別為：{0}，{1}，{2}", r1, r2, r3);


        }

        public static void Play(int x)
        {
            Console.WriteLine($"這是int {x}");
        }
        public static void Play(float f)
        {
            Console.WriteLine($"這是float {f}");
        }

        static void WorkAs(string args, int times)
        {
            Console.WriteLine($"args => {args} , times => {times}, WorkAs(string args,int times)");

        }

        static void WorkAs(string args)
        {
            Console.WriteLine($"args => {args}, WorkAs(string args)");
        }

        static void WorkAs()
        {
            Console.WriteLine("WorkAs()");
        }
    }

    class Test
    {
        public int Compute(int a)
        {
            return a * 1;
        }

        public int Compute(int a, int b)
        {
            return a * b;
        }
        public int Compute(int a, int b, int c)
        {
            return a * b * c;
        }


    }
}
