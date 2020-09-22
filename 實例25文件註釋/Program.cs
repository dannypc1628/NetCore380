using System;
using System.Runtime.CompilerServices;

namespace 實例25文件註釋
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Man man = new Man();
            man.Name = "庚庚";
            man.Age = 18;
            var a = man.是不是魔法師(man.Age);
            Console.WriteLine(man.Name);
            Console.WriteLine($"是不是魔法師:{a}");

            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine($"{input}歲是不是魔法師:{man.是不是魔法師(Convert.ToInt32(input))}");
            }
        }
    }
    /// <summary>
    /// 該類別顯示某個人的基本資訊
    /// </summary>
    /// <remarks>它是一個抽象類別，不能直接實例化</remarks>
    public abstract class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年齡。該屬性的值為<see cref="System.Int32" />型別
        /// </summary>
        public int Age { get; set; }

    }

    public class Man : Person
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="年齡">任何人的年齡</param>
        /// <returns>是不是魔法師，回傳true or false</returns>
        public bool 是不是魔法師(int 年齡)
        {
            if (年齡 >= 30)
                return true;
            else
                return false;
        }
    }
}
