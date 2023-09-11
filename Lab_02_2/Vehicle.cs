using System;

namespace Lab_02_2
{
    public class Vehicle
    {
        protected int Price;
        protected int Speed;
        protected string Date;
        protected string Model;

        public int price
        {
            get { return this.Price; }
        }

        public int speed
        {
            get { return this.Speed; }
        }

        public string date
        {
            get { return this.Date; }
        }

        public string model
        {
            get { return this.Model; }
        }

        public Vehicle(int price, int speed, string date, string model)
        {
            this.Price = price;
            this.Speed = speed;
            this.Date = date;
            this.Model = model;
        }

        public virtual void Print()
        {
        }
    }

    public class Plane : Vehicle
    {
        private int Altitude;
        private int Capacity;

        public Plane(int price, int speed, string date, string model, int altitude, int capacity) : base(price, speed,
            date, model)
        {
            this.Altitude = altitude;
            this.Capacity = capacity;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"Model: {this.model}\t Price: {this.price}\t Speed: {this.speed}\t Date: {this.date}\t Altitude: {this.Altitude}\t Capacity: {this.Capacity}");
        }
    }

    public class Car : Vehicle
    {
        public Car(int price, int speed, string date, string model) : base(price, speed, date, model)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Model: {this.model}\t Price: {this.price}\t Speed: {this.speed}\t Date: {this.date}");
        }
    }

    public class Ship : Vehicle
    {
        private int Capacity;
        private string Port;

        public Ship(int price, int speed, string date, string model, string Port, int capacity) : base(price, speed,
            date, model)
        {
            this.Port = Port;
            this.Capacity = capacity;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"Model: {this.model}\t Price: {this.price}\t Speed: {this.speed}\t Date: {this.date}\t Port: {this.Port}\t Capacity: {this.Capacity}");
        }
    }
}