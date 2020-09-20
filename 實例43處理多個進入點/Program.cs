using System;

namespace 實例43處理多個進入點
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Test
    {
        static void Main(string [] args)
        {
            Console.WriteLine("第二個進入點");
            Console.ReadLine();
        }
    }
}
