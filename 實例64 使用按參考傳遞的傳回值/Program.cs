using System;

namespace 實例64_使用按參考傳遞的傳回值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ref string resStr = ref GetName();


            Console.WriteLine("------不使用按參考傳遞的傳回值--------");
            Test1 t1 = new Test1(100);
            Console.WriteLine("初值：");
            t1.DisplayValue();
            int x = t1.Value;
            x = 200;
            Console.WriteLine("修改屬性傳回值之後");
            t1.DisplayValue();

            Console.WriteLine("\n------使用按參考傳遞的傳回值--------");
            Test2 t2 = new Test2(100);
            Console.WriteLine("初值：");
            t2.DisplayValue();
            ref int y = ref t2.Value;
            y = 200;
            Console.WriteLine("修改屬性傳回值之後");
            t2.DisplayValue();
        }

        public static string _name;
        public static ref string GetName()
        {
            _name = "A";
            return ref _name;
        }
    }

    class Test1
    {
        private int _local;

        public Test1(int init)
        {
            _local = init;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"目前值：{_local}");
        }

        public int Value => _local; // 等同於public int Value() { return _local; }
    }
    class Test2
    {
        private int _local;

        public Test2(int init)
        {
            _local = init;
        }
        public void DisplayValue()
        {
            Console.WriteLine($"目前值：{_local}");
        }

        public ref int Value => ref _local;
    }
}
