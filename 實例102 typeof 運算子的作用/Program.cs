using System;
using System.Reflection;

namespace 實例102_typeof_運算子的作用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 123;
            var t = a.GetType();

            Type tt = typeof(Person);
            Console.WriteLine($"類別的完整名稱{tt.FullName}");
            Console.WriteLine("是否為抽象類別：{0}", tt.IsAbstract ? '是' : '否');
            Console.WriteLine("是否是公共類別：{0}",tt.IsPublic ? '是' : '否');

            PropertyInfo[] props = tt.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("--印出所有的property--");
            foreach(var p in props)
            {
                Console.WriteLine($"{p.Name,-15}-{p.PropertyType.Name,-15}");
            }
        }
    }

    public abstract class Person
    {
        public abstract int Age { get; set; }
    }
}
