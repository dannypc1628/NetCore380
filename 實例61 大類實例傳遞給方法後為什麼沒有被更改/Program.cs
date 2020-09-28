using System;
using System.Data;

namespace 實例61_大類實例傳遞給方法後為什麼沒有被更改
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product pro = new Product();
            pro.Name = "測試產品A";
            pro.Code = 60009;

            // 兩邊都要加上ref
            Update(ref pro);

            Console.WriteLine($"Name={pro.Name} Code={pro.Code}");
        }
        //使用ref後p變數就是pro本身，所以變成pro = new Product
        static void Update(ref Product p)
        {
            p = new Product
            {
                Name = "測試產品C",
                Code = 700021
            };
        }


        //p= new Product之後，p就是跟pro不同物件
        static void Update1(Product p)
        {
            p = new Product
            {
                Name = "測試產品C",
                Code = 700021
            };
        }


        //p跟pro是同一個物件
        static void Update2(Product p)
        {
            p.Name = "測試產品C";
            p.Code = 700021;
        }
    }

    class Product
    {
        public string Name { get; set; }

        public int Code { get; set; }
    }


}
