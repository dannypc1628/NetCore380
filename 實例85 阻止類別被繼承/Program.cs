using System;

namespace 實例85_阻止類別被繼承
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    sealed class Pear 
    {

    }

    class WildPear : Pear //密封類別無法被繼承
    {

    }
}
