using System;
using System.Runtime.CompilerServices;

namespace 實例53_程式跳躍
{
    class Program
    {
        static void Main(string[] args)
        {
        KeyIn:
            Console.WriteLine("請輸入任意鍵，若要結束請按Esc");
            var keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.LeftArrow)
                goto left;
            if (keyInfo.Key == ConsoleKey.RightArrow)
                goto right;
            if (keyInfo.Key == ConsoleKey.UpArrow)
                goto up;
            if (keyInfo.Key == ConsoleKey.DownArrow)
                goto down;
            if (keyInfo.Key == ConsoleKey.Escape)
                return;
            else
                goto other;

            left:
            Console.WriteLine("你按下了左方向鍵");
            goto KeyIn;
        right:
            Console.WriteLine("你按下了右方向鍵");
            goto KeyIn;
        up:
            Console.WriteLine("你按下了上方向鍵");
            goto KeyIn;
        down:
            Console.WriteLine("你按下了下方向鍵");
            goto KeyIn;
        other:
            Console.WriteLine("你按下了其他方向鍵");
            goto KeyIn;

        }
    }
}
