using System;

namespace 實例101_是_大_還是_小_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = 101;
            if (a > 101)
                a = 0;
            else
            {
                a = -1;
            }
            //同上if else
            a = a > 101 ?  0 : -1;

            string s = "abcdefg";

            string msg = "字串長度" + (s.Length <= 5 ? "不超過5" : "已超過5");

            Console.WriteLine(msg);

        }
    }
}
