using System.Reflection;

namespace T28_Refrigerator
{
    public class Refrigerator
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Refrigerator(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public override string ToString()
        {
            return $"Refrigerator {Brand} - {Model}";
        }
        public List<Object> products = new List<Object>();
        public void AddProducts(object variable)
        {
            products.Add(variable);
        }
        public void ShowList()
        {
            Console.WriteLine($"Has items:");
            foreach (var product in products)
                Console.WriteLine(product);
        }
    }
    
    public class Vegetables
    {
        public readonly string Type = "Vegetable";
        public string Name { get; set; }
        public DateOnly Exp_Date { get; set; }
        public Vegetables(string type, string name, DateOnly exp_Date)
        {
            Type = type;
            Name = name;
            Exp_Date = exp_Date;
        }
        public override string ToString()
        {
            return $"Type {Type}, {Name}, Expiring date: {Exp_Date}";
        }
    }
    public class Dairy
    {
        public readonly string Type = "Dairy";
        public string Name { get; set; }
        public DateOnly Exp_Date { get; set; }
        public Dairy(string type, string name, DateOnly exp_Date)
        {
            Type = type;
            Name = name;
            Exp_Date = exp_Date;
        }
        public override string ToString()
        {
            return $"Type {Type}, {Name}, Expiring date: {Exp_Date}";
        }
    }
    public class Meat
    {
        public readonly string Type = "Meat";
        public string Name { get; set; }
        public DateOnly Exp_Date { get; set; }
        public Meat(string type, string name, DateOnly exp_Date)
        {
            Type = type;
            Name = name;
            Exp_Date = exp_Date;
        }
        public override string ToString()
        {
            return $"Type {Type}, {Name}, Expiring date: {Exp_Date}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create new refrigerator
            Refrigerator electrolux = new Refrigerator("Electrolux", "LRS1DF39W");
            Console.WriteLine(electrolux.ToString());

            // Creating items first
            Vegetables cucumber = new Vegetables("Vegetable","Cucumber",new DateOnly(2022,11,14));
            Vegetables tomato = new Vegetables("Vegetable", "Tomato", new DateOnly(2022, 11, 12));
            Dairy Milk = new Dairy("Dairy", "Milk", new DateOnly(2022, 11, 12));
            Dairy Yoghurt = new Dairy("Dairy", "Yoghurt", new DateOnly(2022, 11, 13));
            Meat Chicken = new Meat("Meat", "Chicken Fillet", new DateOnly(2022, 12, 01));
            
            
           
            electrolux.AddProducts(cucumber);
            electrolux.AddProducts(Milk);
            electrolux.AddProducts(Yoghurt);
            electrolux.AddProducts(Chicken);
            electrolux.ShowList();

        }
    }
}