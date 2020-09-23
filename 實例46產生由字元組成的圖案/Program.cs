using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace 實例46產生由字元組成的圖案
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************
            //*******  *******
            //******    ******
            //*****      *****
            //****        ****
            //***          ***
            //**            **
            //*              *
            //*              *
            //**            **
            //***          ***
            //****        ****
            //*****      *****
            //******    ******
            //*******  *******
            //****************
            Console.WriteLine("Hello World!");
            List<string> list1 = new List<string>();
            for (int x = 1; x <= 8; x++)
            {
                string s1 = "";
                int v = 0;
                while (v < x)
                {
                    s1 += "*"; //同等於s1 = s1 + "*";
                    v++; //同等於v = v + 1;

                }
                // 其餘的字元用空格補齊，使字串總長度為8
                s1 = s1.PadRight(8);

                // 將整行字元進行反轉，並產生新字串
                string s2 = new string(s1.Reverse().ToArray());
                // 將兩個字串進行串接
                list1.Add(s1 + s2);
            }

            // 第一輪輸出 - 先印出上半部
            list1.Reverse();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // 第二輪輸出 - 再印出下半部
            list1.Reverse();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
