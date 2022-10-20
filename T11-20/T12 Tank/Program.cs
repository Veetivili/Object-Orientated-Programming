using System.ComponentModel;

namespace T12_Tank
{
    public class Tank
    {
        // Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int CrewNumber { get; set; } = 4;
        public float Speed { get; private set; } = 0.00F;
        public readonly float MaxSpeed = 100.00F;
        // Constructor
        public Tank(string name, string type, int crewNumber)
        {
            Name = name;
            Type = type;
            CrewNumber = crewNumber;
         }
        // Methods
        public float AccelarateTo(float value)
        {
            Console.WriteLine($"Try AccelarateTo: {value}");
            if (value > MaxSpeed)
            {
                Console.WriteLine($"Can't accelarate more than {MaxSpeed}");
                Console.WriteLine($"Speed is not changed, current speed: {Speed}");
                Console.WriteLine("\n");
                return Speed;
            }
            else
            {
                Console.WriteLine($"Speed is accelarated to: {value}");
            }
            Console.WriteLine("\n");
            return Speed = value;
            
        }
        public float SlowTo(float value)
        {
            Console.WriteLine($"Try SlowTo: {value}");
            if (value < 0)
            {
                Console.WriteLine("Speed can't be slower than 0");
                Console.WriteLine($"Speed is not changed, current speed: {Speed}");
                Console.WriteLine("\n");
                return Speed;
            }
            else
            {
                Console.WriteLine($"Speed is slowed down to: {value}");
            }
            Console.WriteLine("\n");
            return Speed = value;
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank("Leopard", "Heavy", 4);
            Console.WriteLine($"Name: {tank.Name}");
            Console.WriteLine($"Type: {tank.Type}");

            Console.WriteLine("\nSet how many Crew members in tank: ");
            int crew = Convert.ToInt32(Console.ReadLine());
            if (crew < 2 || crew > 6)
            {
                Console.WriteLine("Passenger number out of range, min: 2 passengers / max: 6 passengers");
                Console.WriteLine($"CrewNumber value set back to default: {tank.CrewNumber}");
            }    
            else
            {
                tank.CrewNumber = crew;
                Console.WriteLine($"CrewNumber set to: {tank.CrewNumber}");
            }
            Console.WriteLine("\n");

            tank.AccelarateTo(12.00F);
            tank.SlowTo(8.00F);
            tank.AccelarateTo(122.00F);
            tank.AccelarateTo(99.00F);
            tank.SlowTo(-1.00F);


        }
    }
}
