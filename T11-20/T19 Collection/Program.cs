using System.Xml.Schema;

namespace T19_Collection
{
    public class Phone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ReleaseYear { get; set; }
        public string Connection { get; set; }
        public Phone(string name, string model, int releaseYear, string connection)
        {
            Name = name;
            Model = model;
            ReleaseYear = releaseYear;
            Connection = connection;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Release Year: {ReleaseYear}, Connection: {Connection}";
        }
    }
    public class OnePlus : Phone
    {
        public OnePlus(string name, string model, int releaseYear, string connection) :base(name, model, releaseYear, connection)
        {
            Name=name;
            Model = model;
            ReleaseYear=releaseYear;
            Connection=connection;
        }
    }
    public class Nokia : Phone
    {
        public Nokia(string name, string model, int releaseYear, string connection) : base(name, model, releaseYear, connection)
        {
            Name = name;
            Model = model;
            ReleaseYear = releaseYear;
            Connection = connection;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("","",0,"");
            OnePlus onePlus = new OnePlus("OnePlus", "10 Pro", 2022, "5G");
            Nokia nokia = new Nokia("Nokia", "Lumia", 2016, "4G");

            Console.WriteLine(onePlus.ToString());
            Console.WriteLine(nokia.ToString());


        }
    }
}