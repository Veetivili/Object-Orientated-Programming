using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace T8_Television
{
    public class Television
    {
        public int chanel { get; set; }
        public int volume { get; set; }
        public bool power { get; set; }
        public string Power()
        {
            if (power == false)
            {
                return $"\n Power: {power}";
            }
            else
            {
                return $"\n Power: {power}, Chanel: {chanel}: Volume: {volume};";
            }

        }

        public string ChangeChanel()
        {
            if (chanel == 1)
            {
                return $"\n Chanel: {chanel}, Yle 1, Show: Uutiset";
            }
            else if (chanel == 2)
            {
                return $"\n Chanel: {chanel}, Yle 2, Show: A-Studio";
            }
            else if (chanel == 3)
            {
                return $"\n Chanel: {chanel}, MTV 3, Show: Kauniit ja Rohkeat";
            }
            else if (chanel == 4)
            {
                return $"\n Chanel: {chanel}, Nelonen, Show: Selviytyjät Suomi";
            }
            else
            {
                return "No signal, try another chanel.";
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Television television = new Television();
                bool TvPower() 
                {
                    if (television.power == true)
                    {
                        return television.power = false;
                    }
                    else 
                        return television.power = true;                   
                }

                bool showMenu = true; // If showmenu is false, mainmenu isn't shown and program is stopped.

                Console.WriteLine("Press [1] To turn on TV.");
                int startTv = Convert.ToInt32(Console.ReadLine());
                if (startTv == 1) 
                { 
                // Default values when turning on TV
                television.power = true;
                television.chanel = 2;
                television.volume = 12;
                }
                else { showMenu = false; }
                
                
                
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
                
                // Programm is allways returning to this main menu after each loop.
                // Choose function to be executed, new info (Volume, Chanel) is then shown on menu.
                bool MainMenu()
                {
                    
                    
                    Console.WriteLine($"{television.Power()}");
                    Console.WriteLine($"\n1) Change Volume \n2) Change Chanel \n3) Power On/off");

                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            ChangeVolume();
                            return true;
                        case 2:
                            ChangeShow();
                            return true;
                        case 3:
                            TvPower();
                            return showMenu=false;
                        default: return true;

                    }

                    void ChangeShow()
                    {
                        Console.Clear();
                        Console.WriteLine("Previous chanel [1], Next chanel [2]");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                television.chanel--;
                                Console.WriteLine(television.ChangeChanel());
                                break;
                            case 2:
                                television.chanel++;
                                Console.WriteLine(television.ChangeChanel());
                                break;
                        }
                    }


                    void ChangeVolume()
                    {
                        Console.Clear();
                        Console.WriteLine("\n Volume down [1], Volume up [2].");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        ConsoleKeyInfo keyinfo;
                        Console.WriteLine("\n Press enter to keep changing volume \n Press [X] to save volume.");
                        do
                        {
                            keyinfo = Console.ReadKey();
                            switch (choice)
                            {
                                case 1:
                                    television.volume--;
                                    Console.WriteLine($"{television.volume}");
                                    break;
                                case 2:
                                    television.volume++;
                                    Console.WriteLine($"{television.volume}");
                                    break;
                            }
                        }
                        while (keyinfo.Key != ConsoleKey.X);
                        Console.Clear();
                        Console.WriteLine($"Volume set to: {television.volume}");
                    }
                }       
            }
        }
    }
}

