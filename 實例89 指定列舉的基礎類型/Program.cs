using System;

namespace 實例89_指定列舉的基礎類型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum ReadMode : byte
    {
        NewFile = 1,
        OpenCurrent = 2,
        Saved = 3
    }

    public enum PictureQt : uint
    {
        HQ = 4,
        LQ = 12,
        MQ = 7
    }
    
}
