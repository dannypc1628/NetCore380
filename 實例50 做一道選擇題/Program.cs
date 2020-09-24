using System;

namespace 實例50_做一道選擇題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("哪一位歷史人物生活在唐朝？");
                Console.WriteLine("1、蔡邕");
                Console.WriteLine("2、唐寅");
                Console.WriteLine("3、王勃");
                Console.WriteLine("4、蘇軾");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("蔡邕生活在東漢時期");
                        break;
                    case "2":
                        Console.WriteLine("唐寅是明朝人");
                        break;
                    case "3":
                        Console.WriteLine("恭喜你答對了");
                        break;
                    case "4":
                        Console.WriteLine("蘇軾是生活在北宋朝時期");
                        break;
                    default:
                        Console.WriteLine("你未做出有效的選擇");
                        break;
                }
            }
        }
    }
}
