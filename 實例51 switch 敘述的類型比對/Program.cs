using System;

namespace 實例51_switch_敘述的類型比對
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object vx = "abcde";

            switch (vx)
            {
                case int n:
                    Console.WriteLine("int");
                    break;
                case string str:
                    Console.WriteLine("string");
                    break;
                default:
                    Console.WriteLine("未知型別");
                    break;
            }

            object o = new A();
            switch (o) {
                case C c:
                    Console.WriteLine("C");
                    break;
                case B b:
                    Console.WriteLine("B");
                    break;
                case A a:
                    Console.WriteLine("A");
                    break;
            }

            object obj = 0.0001d;

            switch (obj)
            {
                case int v:
                    Console.WriteLine($"{v}是一個int的值");
                    break;
                case decimal v:
                    Console.WriteLine($"{v}是一個decimal的值");
                    break;
                case string v:
                    Console.WriteLine($"{v}是一個string的值");
                    break;
                
                case double v:
                    Console.WriteLine($"{v}是一個double的值");
                    break;
                default:
                    Console.WriteLine("未知類型");
                    break;
                
            }

        }
        class A { }
        class B : A { }
        class C : B { }
    }
}
