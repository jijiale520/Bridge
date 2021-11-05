using System;

namespace Bridge
{
    public class SpeedWay : Road
    {
        public override void Run()
        {
            Console.WriteLine("在高速公路上跑");
        }
    }
}