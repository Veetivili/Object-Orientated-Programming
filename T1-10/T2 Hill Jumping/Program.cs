List<int> Points = new List<int>();
for (int rounds = 1; rounds < 6; rounds++)
{
    
    Console.WriteLine("Judge No." + rounds + " give your points:");
 
    string input = Console.ReadLine();

    while (int.TryParse(input, out int n) == false)
    {
        Console.WriteLine("Only integers allowed, try again inserting number.");
        input = Console.ReadLine();
    }

    int point = Int32.Parse(input);
    Points.Add(point);
}

int TotalPoints = Points.Sum() - Points.Min() - Points.Max();
Console.WriteLine("Total Points:" + TotalPoints);

// Writen by Veeti Hakala AB0197



