using System;

namespace 實例30巢狀結構命名空間
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NTest.NSub1.WorkTask v1 = new NTest.NSub1.WorkTask();

            NTest.NSub2.Tool t1 = new NTest.NSub2.Tool();
        }
    }
}

namespace NTest
{
    namespace NSub1
    {
        class WorkTask
        {

        }
    }

    namespace NSub2
    {
        struct Tool
        {

        }
    }
}
namespace NTest.NSub1
{ 
}
