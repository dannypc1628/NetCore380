using System;

namespace 實例73_將方法作為參數進行傳遞
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 16, 21, 20, 11, 18, 37, 41, 77 };

            //等同 int[] resArr = Array.FindAll(arr, isYes);
            int[] resArr = Array.FindAll(arr, element =>
            {
                if ((element % 2 == 0) || (element % 3 == 0))
                {
                    return true;
                }
                return false;
            });
            Console.WriteLine("符合2或3的倍數條件的結果");
            foreach(var item in resArr)
            {
                Console.WriteLine(item);
            }
        }
        static bool isYes(int element)
        {
            if ((element % 2 == 0) || (element % 3 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
