namespace T23_Queue
{
    public class Checkout_Queue
    {
        private int QueStatus { get; set; } = 0;
        private List<string> People { get; set; } = new List<string>();
        public void GoToQueue()
        {
            Console.WriteLine("---- Testing CheckOut Que ----");
            while (true)
            {
                Console.WriteLine("Give name for the person arriving to the queue. -- Press 'Enter' to stop --");
                var name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine($"There are now {QueStatus} people in Que.");
                    foreach (var item in People)
                        Console.WriteLine(item);
                    break;
                }
                else
                {
                    People.Add(name);
                    QueStatus += 1;
                }
                Console.WriteLine($"There are now {QueStatus} people in Que.");
            }
        }
        public void ExitQueue()
        {
            Console.WriteLine("\n---- Testing Checkout ----");
            Console.WriteLine($"There are now {QueStatus} people in Que.");
            for (int i = People.Count; i > 0; i--)
            {
                Console.WriteLine("-- Serving first customer in Que --");
                Console.WriteLine($"At the moment customer is : {People.ElementAt(0)}");
                People.Remove(People.ElementAt(0));
            }
            Console.WriteLine("All customers are served now.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Checkout_Queue lidl = new Checkout_Queue();
            lidl.GoToQueue();
            lidl.ExitQueue();
        }
    }
}