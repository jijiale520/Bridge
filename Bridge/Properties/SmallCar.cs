using System;

namespace Bridge
{
    public class SmallCar : Car
    {
        public SmallCar(Road _road)
        {
            base.road = _road;
        }
        public override void Run()
        {
            Console.Write("小汽车-》");
            base.road.Run();
        }
    }
}