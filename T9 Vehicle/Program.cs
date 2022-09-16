using System;
using System.Security.Cryptography.X509Certificates;

namespace T9_Vehicle
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tires { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle(string brand, string model, int speed, int tires) : this(brand, model)
        {
            Speed = speed;
            Tires = tires;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}";
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Speed: {Speed}km/h, Tires:{Tires}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects with one command (Anonymous objects)
            Vehicle[] Vehicles = { new Vehicle("Helkama", "Jopo", 15, 2), new Vehicle("Suzuki", "GSX-R", 240, 2), new Vehicle("Ford", "Focus", 180, 4), new Vehicle("Sisu", "LP-400", 100, 6) };
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }

            // Change object properties
            Vehicles[0].Brand = "Solifer"; Vehicles[0].Model = "Vintage";
            Vehicles[1].Brand = "Yamaha"; Vehicles[1].Model = "Bolt R-Spec";
            Vehicles[2].Brand = "Lamborghini"; Vehicles[2].Model = "Aventador";
            Vehicles[3].Brand = "Saab"; Vehicles[3].Model = "Cargo-Carrier";
            
            Console.WriteLine("\nObject properties after change: ");
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle.ShowInfo());
            }
        }
    }
}
    

