using System;

namespace 實例93_檢查列舉實例中是否包含某個標示位
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test t = Test.Model2 | Test.Model3;
            Console.WriteLine($"t = {t}");
            Console.WriteLine($"t & Test.Model2 ={t & Test.Model2}");

            bool b = t.HasFlag(Test.Model3);
            Console.WriteLine($"t.HasFlag(Test.Model3) => {b}");

            Test t2 = Test.Model1 | Test.Model2 | Test.Model3;
            Console.WriteLine($"t2 = {t2} ");//Test.Model預設值是0，所以做OR運算會是0，也就是沒有

            var temp = (t2 & Test.Model1);
            Console.WriteLine($"(t2 & Test.Model1) => {temp} 值{(int)temp}");
            bool b2 = (t2 & Test.Model1) == Test.Model1;
            Console.WriteLine($"(t2 & Test.Model1) == Test.Model1 =>{b2}");
        }
    }

    [Flags]
    enum Test
    {
        Model1,
        Model2,
        Model3
    }
}
