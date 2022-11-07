using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace T24_Car
{
    public class Car : Tire
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TireNumber { get; private set; } = 4;
        readonly List<string> Tires = new List<string>();
        public void AddTires(string var1)
        {
            var NewTire = var1;
            Console.WriteLine("Equipped with tires:");
            while (TireNumber > Tires.Count)
            {
                Tires.Add($"{var1}");
                Console.WriteLine(Tires.Last());
            }  
        }
        public override string ToString()
        {
            return $"\nCreated new Vehicle {Brand} {Model}";
        }
    }

    public class Tire
    {
        public string Manufacturer { get; set; }
        public string TireSize { get; set; }
        public string TireModel { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Porsche";
            car.Model = "Tucan";

            Console.WriteLine(car.ToString());

            Tire Nokia = new Tire();
            Nokia.Manufacturer = "Nokia";
            Nokia.TireModel = "Hakkapeliitta 3";
            Nokia.TireSize = "205/35R18";

            var var1 = Nokia.Manufacturer + " " + Nokia.TireModel + " " + Nokia.TireSize;
            car.AddTires(var1);

            // Car1 Ends

            Car car2 = new Car();
            car2.Brand = "Toyota";
            car2.Model = "Crown";

            Console.WriteLine(car2.ToString());

            Tire Hankook = new Tire();
            Hankook.Manufacturer = "Hankook";
            Hankook.TireModel = "Ventus Prime";
            Hankook.TireSize = "215/55R16";
            var var2 = Hankook.Manufacturer + " " + Hankook.TireModel + " " + Hankook.TireSize;
            car2.AddTires(var2);

            // Car2 Ends

            Car car3 = new Car();
            car3.Brand = "Mitsubishi";
            car3.Model = "Pajero";

            Console.WriteLine(car2.ToString());

            Tire Continental = new Tire();
            Continental.Manufacturer = "Continental";
            Continental.TireModel = "Conti Cross Contact";
            Continental.TireSize = "265/65R17";
            var var3 = Continental.Manufacturer + " " + Continental.TireModel + " " + Continental.TireSize;
            car3.AddTires(var3);   
        }
    }
}