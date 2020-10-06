using System;

namespace 實例84_顯性實現介面
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NetworkManager msg = new NetworkManager();

            IDownloader dl = msg;
            dl.Start();

            IUploader ul = msg;
            ul.Start();
        }
    }
    interface IDownloader
    {
        void Start();
    }
    interface IUploader
    {
        void Start();
    }

    class NetworkManager : IDownloader, IUploader
    {
        //void Start()
        //{
        //    Console.WriteLine("不是正確的Start...");
        //}

        void IDownloader.Start()
        {
            Console.WriteLine("正在下載，請稍等...");
        }

        void IUploader.Start()
        {
            Console.WriteLine("內容上傳中，請稍等...");

        }
    }
}
