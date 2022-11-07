using System.Collections;

namespace T25_Vehicle
{
    public class Tire
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TireSize { get; set; }
        public List<string> Tires { get; set; }
        public Tire(string manufacturer, string model, string tireSize)
        {
            Manufacturer = manufacturer;
            Model = model;
            TireSize = tireSize;
        }

        public override string ToString()
        {
            return $"- Name: {Manufacturer} Model: {Model} Tire Size: {TireSize}";
        }
    }

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int TireCount { get; set; }
        public ArrayList VehicleTires = new ArrayList();
        public ArrayList Vehicles = new ArrayList();
        public override string ToString()
        {
            return $"{Name} model {Model}";
        }
        public void AddVehicle (object vehicle, string name, string model)
        {
            Name = name;
            Model = Model;
            Vehicles.Add(vehicle);
            foreach(var v in Vehicles)
            {
                Console.WriteLine($"\nCreated a new vehicle {v}");
            }

        }
        public void AddTires(object tire,object vehicle, string var1, string var2)
        {
            for (int i = 0; i < TireCount; i++)
            {
                VehicleTires.Add(tire);
                Console.WriteLine($"Tire {var1} added to vehicle {var2}");
            }
                
        }
        public void ShowTires(int j)
        {
            Console.WriteLine($"\nVehicle: {Vehicles[j]} has tires:");
            foreach (var tire in VehicleTires)
            {
                Console.WriteLine(tire);
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Tire Nokia = new Tire("Nokia", "Hakkapeliitta 3", "205/45R17");
            Vehicle Car = new Vehicle();
            Car.Name = "Toyota";
            Car.Model = "Crown";
            Car.TireCount = 4;
            Car.AddVehicle(Car, Car.Name, Car.Model);
            Car.AddTires(Nokia,Car, Nokia.Manufacturer,Car.Name);
            Car.ShowTires(0);

            Tire pirelli = new Tire("Pirelli", "Speedmon13", "140R16");
            Vehicle motorbike = new Vehicle();
            motorbike.Name = "Harley Davidson";
            motorbike.Model = "Softail";
            motorbike.TireCount = 2;
            motorbike.AddVehicle(motorbike, motorbike.Name, motorbike.Model);
            motorbike.AddTires(pirelli,motorbike,pirelli.Manufacturer,motorbike.Name);
            motorbike.ShowTires(0);


            

            
        }
    }
}