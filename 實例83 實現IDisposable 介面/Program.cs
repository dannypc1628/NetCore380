using System;
using System.IO;
using System.Text;

namespace 實例83_實現IDisposable_介面
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(TextWriter wt = new TextWriter())
            {
                wt.WriteText("程式設計真快樂。");
            }//using區塊結束時會自動執行(TextWriter wt)裡面的Dispose();

            TextWriter wt2 = new TextWriter();
            wt2.WriteText("程式設計真快樂。");
            wt2.Dispose();
        }
    }

    class TextWriter : IDisposable
    {
        const string File_Name = "demo.txt";

        FileStream fsWriter = null;

        public TextWriter()
        {
            fsWriter = File.OpenWrite(File_Name);
        }

        public void WriteText(string str)
        {
            //取得文字的位元組陣列
            byte[] data = Encoding.UTF8.GetBytes(str);
            Console.WriteLine("取得文字的位元組陣列");

            //將位元組陣列寫入檔案流
            fsWriter.Write(data, 0, data.Length);
            Console.WriteLine("將位元組陣列寫入檔案流");

            //將緩衝的資料寫入檔案
            fsWriter.Flush();
            Console.WriteLine("將緩衝的資料寫入檔案");

        }

        public void Dispose()
        {
            fsWriter?.Close();

            fsWriter?.Dispose();

            Console.WriteLine("TextWriter已經執行 fsWriter?.Close();");
            Console.WriteLine("TextWriter已經執行 fsWriter?.Dispose();");
        }
                
    }
}
