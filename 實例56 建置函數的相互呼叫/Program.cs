using System;

namespace 實例56_建置函數的相互呼叫
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //無參數建構函式
            Production p1 = new Production();
            Console.WriteLine($"產品編號{p1.ProductId} " +
                              $"\n 產品名稱：{p1.ProductName} \n 生產日期：{p1.ProductDate} \n");

            //呼叫有兩個參數建構函式
            Production p2 = new Production("範例產品",new DateTime(2017,12,12));
            Console.WriteLine($"產品編號{p2.ProductId} " +
                              $"\n 產品名稱：{p2.ProductName} \n 生產日期：{p2.ProductDate} \n");
        }
    }

    public class Production
    {
        /// <summary>
        /// 產品編號
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string  ProductName { get; set; }

        /// <summary>
        /// 生產日期
        /// </summary>
        public DateTime ProductDate { get; set; }

        /// <summary>
        /// 帶三個參數的建構函式
        /// </summary>
        /// <param name="pId">產品編號</param>
        /// <param name="pName">產品名稱</param>
        /// <param name="pDate">生產日期</param>
        public Production(Guid pId, string pName,DateTime pDate)
        {
            ProductId = pId;
            ProductName = pName;
            ProductDate = pDate;
        }

        /// <summary>
        /// 帶兩個參數的建構函式
        /// </summary>
        /// <param name="pName">產品名稱</param>
        /// <param name="pDate">生產日期</param>
        public Production(string pName,DateTime pDate):this(Guid.NewGuid(),pName, pDate)
        {

        }

        /// <summary>
        /// 沒有參數的建構函式
        /// </summary>
        public Production() : this(Guid.NewGuid(), "未知的產品", DateTime.Today)
        {

        }
    }
}
