using System;

namespace 實例57_靜態建置函數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Test.Sample);

            Test t1 = new Test(1);

            Console.WriteLine(Test.Sample);

            Test t2 = new Test(2);


        }
    }

    public class Test
    {
        public static string Sample { get;}

        public int Age { get; set; }
        public Test(int i)
        {
            Console.WriteLine($"執行自己手動實例化建構式 第{i}次");
        }
        static Test()
        {
            Sample = "示範屬性";
            Console.WriteLine("靜態建構函式被呼叫~");
        }
    }
}
