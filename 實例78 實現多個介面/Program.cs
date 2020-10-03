using System;

namespace 實例78_實現多個介面
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OneWork ow = new OneWork();
            ow.StartWork();
            ow.EndWork();

        }
    }

    interface IRunner1
    {
        void StartWork();
    }

    interface IRunner2
    {
        void EndWork();
    }
    
    class OneWork : IRunner1, IRunner2
    {
        public void StartWork()
        {
            Console.WriteLine("開始操作");
        }

        public void EndWork()
        {
            Console.WriteLine("結束操作");

        }
    }
}
