using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

int grade0 = 19;
int grade1 = 29;
int grade2 = 39; // Variables defined for grades
int grade3 = 49;
int grade4 = 59;
string Restart = "no";
do // Using Do...While loop for running application again.
{
    Console.WriteLine("Insert your score:");
    string input = Console.ReadLine();
    while (int.TryParse(input, out int n) == false) // Making sure input is parsible.
    {
        Console.WriteLine("Por favor, try inserting number."); // Give message for wrong input
        input = Console.ReadLine();
    }

    int score = Int32.Parse(input); // Actual parsing for input.

    if (score <= grade0)
    {
        Console.WriteLine("Your grade is: 0");
    }
    else if (score <= grade1)
    {
        Console.WriteLine("Your grade is: 1");
    }
    else if (score <= grade2)
    {
        Console.WriteLine("Your grade is: 2");
    }
    else if (score <= grade3)
    {
        Console.WriteLine("Your grade is: 3");
    }
    else if (score <= grade4)
    {
        Console.WriteLine("Your grade is: 4");
    }
    else
    {
        Console.WriteLine("Your grade is: 5");
    };

    Console.WriteLine("Write 'yes' to try again!");
    Restart = Console.ReadLine();
}
while (Restart == "yes");

// Writen by Veeti Hakala @AB0197
