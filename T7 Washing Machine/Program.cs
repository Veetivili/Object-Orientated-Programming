using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace T7_Washing_Machine
{
    public class WashingMachine
    {
        public string programm { get; set; }
        public int temperature { get; set; }
        public int speed { get; set; }
        public double duration { get; set; }
        public WashingMachine(string Programm, int Temperature, int Speed, double Duration)
        {
            programm = Programm;
            temperature = Temperature;
            speed = Speed;
            duration = Duration;
        }
        public string ShowAll()
        {
            return $"\n Selected programm: {programm}: Temperature is: {temperature} Celsius degrees, Spin speed is: {speed} RPM and estimated duration: {duration} hours.";
        }
        public string Start()
        {
            return $"\n Programm: {programm} is now washing";
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose programm, cotton [1] or mix[2]");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                WashingMachine cotton = new WashingMachine("cotton", 60, 1400, 2.4);
                Console.WriteLine($"{cotton.ShowAll()}");
                Console.WriteLine($"Start programm? Yes [1], Terminate operation [2]");
                string start = Console.ReadLine();
                if (start == "1")
                {
                    Console.WriteLine($"{cotton.Start()}");
                }
                else
                {
                    Console.Write("Operation Cancelled");
                }
            }


            else if (choice == "2")
            {
                WashingMachine mix = new WashingMachine("mix", 30, 800, 1.2);
                Console.WriteLine($"{mix.ShowAll()}");
                Console.WriteLine($"Start programm? Yes [1], Terminate operation [2]");
                string start = Console.ReadLine();
                if (start == "1")
                {
                    Console.WriteLine($"{mix.Start()}");
                }
                else
                {
                    Console.Write("Operation Cancelled");
                }
            }
            
           
            
            

        }
    }
}