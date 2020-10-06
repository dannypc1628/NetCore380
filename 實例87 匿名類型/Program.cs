using System;

namespace 實例87_匿名類型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var d = new
            {
                Color = "白色",
                Size = 43.6f,
                Number = 7988
            };
            //d.Color = "sdfsf"; 無法修改唯獨屬性

            string str = $"顏色：{d.Color}\n 尺碼：{d.Size} \n 編號：{d.Number}";

            Console.WriteLine("商品資訊{0}", str);
        }
    }
}
