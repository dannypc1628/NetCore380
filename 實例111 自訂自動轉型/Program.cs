using System;

namespace 實例111_自訂自動轉型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RectArea v = new RectArea(12, 15);
            int area1 = v;//自動轉型

            int area2 = (int)v;//顯性(明確)轉型

            Console.WriteLine($"矩形資訊：\n寬：{v.Width}\n高：{v.Height}\n面積：{area1}");
            Console.WriteLine($"矩形資訊：\n寬：{v.Width}\n高：{v.Height}\n面積：{area2}");

        }
    }

    public class RectArea
    {
        public int Width { get; set; }

        public int Height { get; set; }
        public RectArea(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public static implicit operator int(RectArea r)
        {
            return r.Height * r.Width;
        }
    }
}
