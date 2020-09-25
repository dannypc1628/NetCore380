using System;

namespace 實例55_為結構定義建置函數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //無需使用new運算子
            Rectangle r1;
            r1.Width = 10;
            r1.Height = 25;

            //明確(顯性)使用new運算子
            Rectangle r2 =  new Rectangle();
            r2.Width = 10;
            r2.Height = 25;

            //使用帶有參數的建構函式
            Rectangle r3 = new Rectangle(45, 185);
        }
    }
    struct Rectangle
    {
        public int Width;

        public int Height;
            
        public Rectangle(int w,int h)
        {
            Width = w;
            Height = h;
        }
    }

}
