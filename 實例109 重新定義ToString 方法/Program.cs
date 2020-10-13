using System;

namespace 實例109_重新定義ToString_方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Production[] pres =
            {
                new Production
                {
                    ID=1,
                    Width=150,
                    Height =70,
                    SerialNum = "T-312756-K3"
                },
                 new Production
                {
                    ID=2,
                    Width=200,
                    Height =85,
                    SerialNum = "T-33158-K7"
                }
                 ,
                  new Production
                {
                    ID=3,
                    Width=210,
                    Height =75,
                    SerialNum = "T-23158-K8"
                },
                   new Production
                {
                    ID=4,
                    Width=270,
                    Height =56,
                    SerialNum = "T-600001-C4"
                }, new Production
                {
                    ID=5,
                    Width=260,
                    Height =90,
                    SerialNum = "T-712558-C7"
                }
            };
            foreach(var p in pres)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

    public class Production
    {
        public int ID { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string SerialNum { get; set; }

        public override string ToString()
        {
            return $"產品序號:{SerialNum}，規格(公釐):{Width} × {Height}";
        }

    }
}
