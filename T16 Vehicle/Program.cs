using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace T16_Vehicle
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return $"\nName: {Name}, Model: {Model}, ModelYear: {ModelYear}, Color: {Color}";
        }
        public Vehicle(string name, string model, int modelYear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }
    }

    public class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; } = "";
        public override string ToString()
        {
            string Msg = "";
            if (GearWheels == true)
            {
              Msg = $"\nName: {Name}, Model: {Model}, ModelYear: {ModelYear}, Color: {Color}, HasGears: {GearWheels}, GearName: {GearName}";
                return Msg;
            }
            else if (GearWheels == false)
            {
                GearName = " ";
                return $"\nName: {Name}, Model: {Model}, ModelYear: {ModelYear}, Color: {Color}, HasGears: {GearWheels}, GearName: {GearName}";
            }
            return Msg;
        }
        public Bike(bool gearWheels, string name, string model, int modelYear, string color) : base(name, model, modelYear, color)
        {
            GearWheels = gearWheels;
        }
    }

    public class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int BoatSeats { get; set; }
        public override string ToString()
        {
            return $"\nName: {Name}, Model: {Model}, ModelYear: {ModelYear}, Color: {Color}, Boat Type: {BoatType}, Seats: {BoatSeats}";
        }
        public Boat(string boatType, int boatSeats, string name, string model, int modelYear, string color) :base(name, model, modelYear, color)
        {
            BoatType = boatType;
            BoatSeats = boatSeats;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Audi", "A7", 2021, "Gray");
            Bike bike1 = new Bike(true, "Jopo", "Nopsa", 2014, "Purple"); 
            bike1.GearName = "Shimano Nexus";
            Bike bike2 = new Bike(false, "Helkama", "Sprintter", 2001, "Blue");
            Boat kayak = new Boat("Kayak", 1, "LakeMaster", "L3000", 2022, "Green");
            Boat motorboat = new Boat("MotorBoat", 5, "Särki", "T470LS", 1988, "Yellow");




            Console.WriteLine(car.ToString());
            Console.WriteLine(bike1.ToString());
            Console.WriteLine(bike2.ToString());
            Console.WriteLine(motorboat.ToString());
            Console.WriteLine(kayak.ToString());
        }
    }
}