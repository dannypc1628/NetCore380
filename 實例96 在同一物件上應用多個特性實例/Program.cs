using System;

namespace 實例96_在同一物件上應用多個特性實例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Docs a = new Docs();
        }
    }
    //[Obsolete]
    [Obsolete]
    class Docs
    {

    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Ver { get; set; }
    }

    [Custom(Ver = "1.0.0.2")]
    [Custom(Ver="1.0.0.1"), Custom(Ver = "1.0.0.3")]
    public class AppData
    {

    }
}
