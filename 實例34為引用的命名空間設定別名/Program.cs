using System;
using ext = Orgamization.Componetnt.Extensions;
using mps = Orgamization.Componetnt.MainParts;

namespace 實例34為引用的命名空間設定別名
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ext.BackgroundWork bw1 = new ext.BackgroundWork();
            mps.BackgroundWork bw2 = new mps.BackgroundWork();

        }
    }
}

namespace Orgamization.Componetnt.Extensions
{
    public class BackgroundWork { }
}

namespace Orgamization.Componetnt.MainParts
{
    public class BackgroundWork { }

}
