using System;

namespace 實例92_取得列舉中常數的名稱
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Enum.GetName(typeof(DayOfWeek),1));
            Console.WriteLine(Enum.GetName(typeof(DayOfWeek), 5));

            string[] days = Enum.GetNames(typeof(DayOfWeek));

            foreach(string d in days)
            {
                Console.WriteLine(d);
            }
        }
    }

}
