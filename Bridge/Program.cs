namespace Bridge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //print：小汽车-》在高速公路上跑
            Car smallCar = new SmallCar(new SpeedWay());
            smallCar.Run();
            //print：小汽车-》在街道公里上跑
            smallCar = new SmallCar(new StreetWay());
            smallCar.Run();
            
            //print：巴士-》在高速公路上跑
            Car bus = new Bus(new SpeedWay());
            bus.Run();
            //print：巴士-》在街道公里上跑
            bus = new Bus(new StreetWay());
            bus.Run();
        }
    }
}