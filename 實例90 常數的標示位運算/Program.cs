using System;

namespace 實例90_常數的標示位運算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReadMode.NewFile|ReadMode.OpenCurrent); //沒使用[FlagsAttribute]
            Console.WriteLine(TrackItem.Track1 | TrackItem.Track2);   //有使用[FlagsAttribute]
            Console.WriteLine(TrackItem.Track1 & TrackItem.Track2);
            Console.WriteLine($"{TrackItem.AllTracks} -- {(int)TrackItem.AllTracks}");


            TrackItem t1 = TrackItem.Track1 | TrackItem.Track2;
            TrackItem t2 = TrackItem.Track3 | TrackItem.Track4 | TrackItem.Track5;
            TrackItem t3 = TrackItem.Track1 | TrackItem.Track2 | TrackItem.Track3 | TrackItem.Track4 | TrackItem.Track5;

            OutputInfo(t1);
            OutputInfo(t2);
            OutputInfo(t3);


        }

        static void OutputInfo(TrackItem t)
        {
            string p1 = t.ToString();
            string p2 = Convert.ToString((int)t, 2).PadLeft(5, '0');
            Console.WriteLine($"{p2} -- {p1}");
            Console.WriteLine($"{p2,-4} -- {p1}");

        }
    }   


    [FlagsAttribute]
    enum TrackItem : short
    {
        Track1 = 1, // 00001
        Track2 = 2, // 00010
        Track3 = 4, // 00100
        Track4 = 8, // 01000
        Track5 = 16,// 10000
        AllTracks = Track1| Track2| Track3| Track4| Track5 , // 11111
    }

    [FlagsAttribute]
    enum MultiHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    }
    public enum ReadMode 
    {
        NewFile = 1,
        OpenCurrent = 2,
        Saved = 3
    }
}
