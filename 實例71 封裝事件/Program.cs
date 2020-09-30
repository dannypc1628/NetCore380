using System;

namespace 實例71_封裝事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test t = new Test();

            t.Worked += (k, f) => Console.WriteLine($"你已經呼叫了{f}次實例");

            t.Run();
            t.Run();
            t.Run();
            t.Run();

        }

    }
    public delegate void DemoEventDelegate(object obj, int count);

    class Test
    {
        private DemoEventDelegate _myEvent;
        private int _c = 0;

        public event DemoEventDelegate Worked
        {
            add
            {
                if (value != null)
                    _myEvent += value;
            }
            remove
            {
                _myEvent -= value;
            }
        }

        public void Run()
        {
            _myEvent?.Invoke(this, ++_c);
            //等同於
            //if (_myEvent != null)
            //    _myEvent(this, ++c);


        }

    }
}
