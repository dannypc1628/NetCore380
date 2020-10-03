using System;
using System.ComponentModel.DataAnnotations;

namespace 實例80_隱藏建置函數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Camara c = Camara.CurrentInstance;//因為建構函式private所以無法從外部用new Camara()取得實例;
            Console.WriteLine($"裝置標示：{c.DeviceID}");
        }
    }

    class Camara
    {
        private Guid _deviceID;

        private static Camara _currentInstance = new Camara();

        public static Camara CurrentInstance => _currentInstance;

        private Camara()
        {
            _deviceID = Guid.NewGuid();
        }

        public Guid DeviceID => _deviceID;
    }
}
