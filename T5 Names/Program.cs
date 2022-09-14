using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections;

string restartProgramn = "no";

do
{   
    Console.WriteLine("Please, give names and birth year of a person. Empty input will stop the input.");
    string userInput = Console.ReadLine();

    
    Console.WriteLine("Try again?");
    restartProgramn = "yes";
    
    return userInput;

}
while (restartProgramn == "yes");

string personName = GetLetters(userInput);

int birthYear = Convert.ToInt32(GetNumbers(userInput));
int ageNumber = 2022 - birthYear; // Converting birthyear to integer to make calculations and then converting back to string for the output.
string age = ageNumber.ToString();

SortedList people = new SortedList();
people.Add(personName, ageNumber);

Console.WriteLine($"{personName} is {age} years old.");

string GetNumbers(string input) // Seperating birthyear from the input
{
    return new string(input.Where(c => char.IsDigit(c)).ToArray());
}

string GetLetters(string input) // Seperating name from the input
{
    return new string(input.Where((c) => char.IsLetter(c)).ToArray());
}


for (int i = 0; i < people.Count; i++)
{
    Console.WriteLine("{0}:\t{1}", people.GetKey(i), people.GetByIndex(i));
}