using System;

namespace 實例66_可選參數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Something(20, 100, true);

            Something(31, 1);

            //Something(900, ,true);這是錯誤的寫法
            Something(p1: 65, p3: true);

        }

        static void Something(int p1, byte p2 =255 ,bool p3 = false)
        {
            string msg = "參數列表\n" + $"{nameof(p1)} = {p1} \n{nameof(p2)} = {p2}"
                        + $"\n{nameof(p3)} = {p3} ";
            Console.WriteLine(msg);
        }
    }
}
