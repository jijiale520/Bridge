using System;

namespace Bridge
{
    public class Bus : Car
    {
        public Bus(Road _road)
        {
            base.road = _road;
        }
        public override void Run()
        {
            Console.Write("巴士-》");
            base.road.Run();
        }
    }
}