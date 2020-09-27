using System;

namespace 實例58_驗證屬性值的有效性
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User u = new User();
            u.UserName = "123";
            Console.WriteLine(u.UserName);

            try
            {
                u.UserName = "Tom";
                u.Password = "123456";
            }
            catch(Exception ex)
            {
                Console.WriteLine($"錯誤：{ex.Message}");
            }
        }
    }
    class User
    {
        private string _userName;

        public string UserName
        {
            get {
                Console.WriteLine($"你正在執行取值函式");    
                return _userName; 
            }

            set
            {
                Console.WriteLine($"你要設定的值為{value}");
                if (value.Length > 15)
                {
                    throw new ArgumentException("使用者名稱長度不可以超過15個字元");
                }
                _userName = value;
            }
        }

        string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if(value.Length < 8)
                {
                    throw new ArgumentException("密碼長度至少要8個位");
                }
                _password = value;
            }
        }
    }
}
