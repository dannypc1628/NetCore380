using System;
using System.Text;

namespace 實例42取得命令列參數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StringBuilder sbd = new StringBuilder();
            sbd.AppendLine("接收到的命令列參數");

            foreach(string a in args)
            {
                sbd.AppendFormat("這裡{0}<--,{1}", a,"333");
            }
            Console.WriteLine(sbd);

            Console.ReadLine();
        }
    }
}
