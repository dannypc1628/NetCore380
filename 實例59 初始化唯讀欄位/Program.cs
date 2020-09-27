using System;

namespace 實例59_初始化唯讀欄位
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SomeType s = new SomeType("aaaa");
            Console.WriteLine(s.GenericKey);
            // s.GenericKey = "qwafsf"; // 唯獨欄位初始設定後不可以修改;
        }
    }

    class SomeType
    {
        public readonly string GenericKey = "123123"; // 在初始化建構函式中能進行設定修改，而之後不能修改

        public const string God = "Me";//會在程式執行前就寫死叫Me，不可修改
        public SomeType(string keys)
        {
            GenericKey = keys;
            
        }

    }
}
