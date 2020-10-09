using System;

namespace 實例98_方法的傳回值如何應用特性
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [return:CheckSum]
        static string SaySomeing()
        {
            return "Hello";
        }
    }

    //[My]
    public class Checker
    {
        //[My]
        public int SomeValue { get; set; }
    }

    [AttributeUsage(AttributeTargets.ReturnValue)]
    public class CheckSumAttribute : Attribute
    {

    }
}
