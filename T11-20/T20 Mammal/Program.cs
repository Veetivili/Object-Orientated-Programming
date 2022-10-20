using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace T20_Mammal
{
    public abstract class Mammal
    {
        public double Age { get; set; }
        public abstract void Move();
    }
    public class Human : Mammal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public override void Move()
        {
            Console.WriteLine("Moving!");
        }
        public void Grow()
        {
            Age++;
            Console.WriteLine($"Has grown by one year! Age now: {Age}");
        }
    }
    public class Baby : Human
    {
        public string Diaper { get; set; }
        public override void Move()
        {
            Console.WriteLine("Crawling!");
        }
        public override string ToString()
        {
            return $"\nName: {Name}, \nHeight: {Height}cm,\nWeight: {Weight}kg, \nAge: {Age}, \nDiaper: {Diaper}";
        }
    }
    public class Adult : Human
    {
        public string Auto { get; set; }
        public override void Move()
        {
            Console.WriteLine("Walking!");
        }
        public override string ToString()
        {
            return $"\nName: {Name}, \nHeight: {Height}cm,\nWeight: {Weight}kg, \nAge: {Age}, \nAuto: {Auto}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adult adult1 = new Adult();
            adult1.Name = "Osmo";
            adult1.Height = 172;
            adult1.Weight = 74;
            adult1.Age = 33;
            adult1.Auto = "Toyota";
            Console.WriteLine(adult1.ToString());
            adult1.Move();
            adult1.Grow();

            Adult adult2 = new Adult();
            adult2.Name = "Marjatta";
            adult2.Height = 168;
            adult2.Weight = 58;
            adult2.Age = 24;
            adult2.Auto = "No car";
            Console.WriteLine(adult2.ToString());
            adult2.Move();
            adult2.Grow();

            Baby baby1 = new Baby();
            baby1.Name = "Mikko";
            baby1.Height = 48;
            baby1.Weight = 5.7;
            baby1.Age = 0.25;
            baby1.Diaper = "Pampers";
            Console.WriteLine(baby1.ToString());
            baby1.Move();
            baby1.Grow();

            Baby baby2 = new Baby();
            baby2.Name = "Tiina";
            baby2.Height = 101;
            baby2.Weight = 14;
            baby2.Age = 1;
            baby2.Diaper = "Pampers";
            
            Console.WriteLine(baby2.ToString());
            baby2.Move();
            baby2.Grow();




        }
    }
}