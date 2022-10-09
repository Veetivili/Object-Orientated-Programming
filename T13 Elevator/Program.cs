namespace T13_Elevator
{
    internal class Program
    {
        public class Elevator 
        {
            public int CurrentFloor { get; private set; } = 1;
            public void ChangeFloor(int floor, out string message)
            {
                Console.WriteLine("Give a new floor number (1-5)");
                if (floor < 0)
                {
                    message = $"{floor}\nFloor is too Small";
                }
                else if (floor > 5) 
                {
                    message = $"{floor}\nFloor is too Big!";
                }
                else
                {
                    CurrentFloor = floor;
                    message = $"{floor}\nElevator is now in floor: {CurrentFloor}";
                }
                
                //message = "Give a new floor";
            }
        }
        
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            string message = "";
            Console.WriteLine($"Elevator is now in: {elevator.CurrentFloor}");
            int floor = 2;
            elevator.ChangeFloor(floor, out message);
            Console.WriteLine(message);
            floor = -1;
            elevator.ChangeFloor(floor, out message);
            Console.WriteLine(message);
            floor = 6;
            elevator.ChangeFloor(floor, out message);
            Console.WriteLine(message);
            floor = 5;
            elevator.ChangeFloor(floor, out message);
            Console.WriteLine(message);

        }
    }
}