using System;

namespace 實例107_輸出整數的二進位表示形式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte v1 = 155;
            int v2 = 916652;
            long v3 = 1200365172;
            short v4 = 5185;

            string c1 = Convert.ToString(v1, 2);
            string c2 = Convert.ToString(v2, 2);
            string c3 = Convert.ToString(v3, 2);
            string c4 = Convert.ToString(v4, 2);

            double dd = Convert.ToDouble(v3);
            double ddd = (double)(v3);


            Console.WriteLine($"{v1,-15} {c1,-80}");
            Console.WriteLine($"{v2,-15} {c2,-80}");
            Console.WriteLine($"{v3,-15} {c3,-80}");
            Console.WriteLine($"{v4,-15} {c4,-80}");


        }
    }
}
