using System;

namespace 實例33使用全域命名空間
{
    class Program
    {
        public class System { }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            global::System.Version v = new global::System.Version();
        }
    }
}
