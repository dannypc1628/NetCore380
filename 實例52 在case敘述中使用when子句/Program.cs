using System;
using System.Collections;
using System.Collections.Generic;

namespace 實例52_在case敘述中使用when子句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1 null
            DisplayInfo(null);

            //2 空陣列
            int[] arr = { };
            DisplayInfo(arr);

            //3 空列表
            List<long> list = new List<long>();
            DisplayInfo(list);

            //4 包含元素的陣列
            byte[] arr2 = { 36, 2, 54, 7 };
            DisplayInfo(arr2);

            //5 包含項目的列表
            List<int> list2 = new List<int>() { 21, 13, 62, 8, 19 };
            DisplayInfo(list2);
        }

        static void DisplayInfo(object instance)
        {
            switch (instance)
            {
                case null:
                    Console.WriteLine("此物件未實例化");
                    break;
                case Array arr when arr.Length == 0:
                    Console.WriteLine("這個空陣列");
                    break;
                case Array arr:
                    Console.WriteLine($"陣列包含{arr.Length} 個元素");
                    break;
                case IList list when list.Count == 0:
                    Console.WriteLine($"這個空列表");
                    break;
                case IList list:
                    Console.WriteLine($"列表中共有{list.Count}項");
                    break;
            }
        }
    }
}
