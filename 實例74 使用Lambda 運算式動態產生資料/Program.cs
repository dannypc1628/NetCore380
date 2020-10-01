using System;
using System.Collections;
using System.Collections.Generic;

namespace 實例74_使用Lambda_運算式動態產生資料
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // () =>{ return 123} 沒有參數
            // (a) =>{ return 123} 一個參數
            // a =>{ return 123} 同上，只有一個參數時()可省略
            // (a,b,c) =>{ return 123} 多個參數

            DataMange dm = new DataMange( ()=> new Dictionary<int, string> { 
                [1] = "window",
                [2] = "house",
                [12] = "12claim",
                [3] = "kite",
                [33] ="abcdefg",
                [4] = "noodless",
                [5] = "claim",

            });
            dm.DisplayData();
        }
    }
    public class DataMange
    {
        private IDictionary<int, string> _dictionaryData;

        public DataMange(Func<IDictionary<int, string>> data)
        {
            _dictionaryData = data();
        }

        public void DisplayData()
        {
            Console.WriteLine("--資料列表--");
            foreach(var kp in _dictionaryData)
            {
                Console.WriteLine($"{kp.Key,4}\t{kp.Value}");
            }
        }
    }
}
