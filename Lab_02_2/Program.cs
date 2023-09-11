namespace Lab_02_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int car1Speed = 100;
            int car1Price = 10;
            string car1Date = "12.12.1997";
            string car1Model = "Impreza";
            Car car1 = new Car(car1Price, car1Speed, car1Date, car1Model);
            car1.Print();

            int plane1Speed = 1000;
            int plane1Price = 10000;
            string plane1Date = "11.11.1967";
            string plane1Model = "Migg27";
            int plane1Capacity = 1;
            int plane1Altitude = 20000;
            Plane plane1 = new Plane(plane1Price, plane1Speed, plane1Date, plane1Model, plane1Altitude, plane1Capacity);
            plane1.Print();

            int ship1Speed = 50;
            int ship1Price = 150000;
            string ship1Date = "13.04.2004";
            string ship1Model = "Tanker";
            string ship1Port = "Port1";
            int ship1Capacity = 150;
            Ship ship1 = new Ship(ship1Price, ship1Speed, ship1Date, ship1Model, ship1Port, ship1Capacity);
            ship1.Print();
        }
    }
}