string Restart = "no";

static void ConsumptionMethod(int distance)
{
    Random rnd = new Random();
    double rndConsumption = rnd.NextDouble(); // Creating random double
    double randomConsumption = rndConsumption * (9.01 - 5.99) + 5.99; // Specifying range for double
    double cost = randomConsumption * 2.5 * ((double)distance / 100);
    string costText = cost.ToString("N2"); // Casting double to text for output showing with precision of 2 decimals.
    double consumption = randomConsumption * ((double)distance / 100);
    string consumptionText = consumption.ToString("N2");
    Console.WriteLine("Fuel consumption is: " + consumptionText + " liters and it costs: " + costText + " euros");
}

do // Using Do...While loop for running application again.
{
    Console.WriteLine("Insert distance driven as an number:");
    string input = Console.ReadLine();
    while (int.TryParse(input, out int n) == false) // Making sure input is parsible.
    {
        Console.WriteLine("Distance must be an integer number, please try again:"); // Give message for wrong input
        input = Console.ReadLine();
    }

    int distance = Int32.Parse(input); // Actual parsing for input.

    ConsumptionMethod(distance);

    Console.WriteLine("Write 'yes' to try again!");
    Restart = Console.ReadLine();
}
while (Restart == "yes");

// Writen by Veeti Hakala @AB0197

