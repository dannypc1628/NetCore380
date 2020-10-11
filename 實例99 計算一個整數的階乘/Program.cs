using System;

namespace 實例99_計算一個整數的階乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 4;
            long r = Compute(n);

            Console.WriteLine($"{n} 的階乘為{r}");
        }

        static long Compute(int num)
        {
            if (num == 0)
            {
                return -1L;
            }
            long result = 1L;
            int temp = 1;
            //  5! = 1 x 2 x 3 x 4 x5
            while (temp <= num)
            {
                result = result * temp;
                temp++;
            }
            return result;
        }
    }
}
