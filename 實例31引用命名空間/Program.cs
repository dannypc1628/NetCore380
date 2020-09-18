using System;
using System.Collections;
using System.Collections.Generic;

namespace 實例31引用命名空間
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //現在如非必要，千萬不要使用ArrayList，請用List<T>
            ArrayList myList = new ArrayList();

            myList.Add("Tom");
            myList.Add("Jim");
            myList.Add("Jack");


            foreach (object o in myList)
            {
                Console.WriteLine(o.ToString());
            }
            //List<T>範例
            List<string> list = new List<string>();
            list.Add("");
            list.Add("Tom");
            list.Add("Jim");
            list.Add("Jack");

            foreach (object o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
