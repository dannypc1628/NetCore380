using System;
using 實例54_宣告公共類別;

namespace 實例54_宣告公共類別測試internal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ant a = new Ant();
            實例54_宣告公共類別.Drangonfly d = new Drangonfly();
            //實例54_宣告公共類別.Program p = new 實例54_宣告公共類別.Program(); //無法存取
        }
    }
}
