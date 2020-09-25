using System;

namespace 實例54_宣告公共類別
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ant v1 = default(Ant);

            Drangonfly v2 = default;

            Spider v3 = default;

        }
    }

    public class Ant { }

    public class Drangonfly { }

    public class Spider { }
}
