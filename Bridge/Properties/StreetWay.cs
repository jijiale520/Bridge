using System;

namespace Bridge
{
    public class StreetWay : Road
    {
        public override void Run()
        {
            Console.WriteLine("在街道公里上跑");
        }
    }
}