using System;
using System.Reflection;

namespace 實例97_在執行時檢索特性實例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test v = new Test { RawName = "k004d6ex915f" };
            bool b = CheckTest(v, nameof(Test.RawName));
            if (b)
            {
                Console.WriteLine("驗證通過");
            }
            else
            {
                Console.WriteLine("驗證失敗");
            }
        }

        static bool CheckTest(Test t , string propty) 
        {
            Type type = t.GetType();
            PropertyInfo prop = type.GetProperty(propty, BindingFlags.Public | BindingFlags.Instance);
            if(prop == null)
            {
                return false;
            }
            Console.WriteLine(prop.Name);

            MyAttribute att = prop.GetCustomAttribute<MyAttribute>();

            string value = prop.GetValue(t) as string;
            Console.WriteLine($"value = {value}");
            if(string.IsNullOrEmpty(value)){
                Console.WriteLine("IsNullOrEmpty");
                return false;
            }
            if(value.StartsWith(att.StartChar) == false)
            {
                Console.WriteLine("StartChar error");

                return false;
            }
            if(value.Length > att.MaxLength)
            {
                Console.WriteLine($"{value}.Length = {value.Length} >{att.MaxLength}");

                return false;
            }
            return true;
        }
    }

    public class Test
    {
        [MyAttribute(StartChar ='k' ,MaxLength = 7)]
        public string RawName { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public  class MyAttribute : Attribute
    {
        public char StartChar { get; set; }

        public int MaxLength { get; set; }
    }
}
