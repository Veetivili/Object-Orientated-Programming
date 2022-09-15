namespace T9_Vehicle
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tires { get; set; }

        public Vehicle (string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle (string brand, string model, int speed, int tires): this (brand, model)
        {
            Speed = speed;
            Tires = tires;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}