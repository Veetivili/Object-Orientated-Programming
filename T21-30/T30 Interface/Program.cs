using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace T30_Interface
{
    public interface IHunter
    {
        void ShootingRifle();
    }
    public interface IPrey
    {
        void EscapeHunter();
    }
    public class Human : IHunter
    {
        public string Name { get; set; }
        public Human()
        {
            Name = "Xavier";
            Console.WriteLine($"\n{Name} says:");
        }
        public void ShootingRifle()
        {
            Console.WriteLine("--Paw!-- Did it hit?");
        }
    }
    public class Deer : IPrey
    {
        public string Name { get; set; }
        public Deer()
        {
            Name = "Bambi";
            Console.WriteLine($"\n{Name} says:");
        }
        public void EscapeHunter()
        {
            Console.WriteLine("--Intense hoof clattering---");
            Console.WriteLine("That bullet went close!");
        }
    }
    public class Soldier : IHunter,IPrey
    {
        public string Name { get; set; }
        public Soldier()
        {
            Name = "Timmy";
            Console.WriteLine($"\n{Name} says:");
        }
        public void ShootingRifle()
        {
            Console.WriteLine("--Paw!-- Did it hit?");
        }
        public void EscapeHunter()
        {
            Console.WriteLine("Definetly did not!");
            Console.WriteLine("Now enemy is hunting me!?!?!?");
            Console.WriteLine($"--Boots clattering to ground when {Name} running--");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new();
            human.ShootingRifle();

            Deer deer = new();
            deer.EscapeHunter();

            Soldier soldier = new();
            soldier.ShootingRifle();
            soldier.EscapeHunter();
        }
    }
}