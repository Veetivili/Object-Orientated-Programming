Console.WriteLine("Please give a word or sentence");
string input = Console.ReadLine();
string str = input, rev = "";
foreach (char c in str) 
{ 
    rev = c + rev; 
} if (str.Equals(rev, StringComparison.OrdinalIgnoreCase)) 
    Console.WriteLine("String is Palindrome"); 
    else 
    Console.WriteLine("String is not Palindrome"); Console.ReadKey();  

// Writen by Veeti Hakala @AB0197