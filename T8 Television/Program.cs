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
        //public Television(int Chanel, int Volume, bool Power)
        //{
        //    chanel = Chanel;
        //    volume = Volume;
        //    power = Power;
        //}
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

                // Default values when turning on TV
                television.power = true;
                television.chanel = 3;
                television.volume = 12;

                bool showMenu = true;
                while (showMenu)
                {
                    
                    showMenu = MainMenu();
                }
                
                bool MainMenu()
                {
                    if (television.power != true)
                    {
                        Console.Clear();
                        Console.WriteLine("\n Turn on TV: [1] \n Exit [2]");
                        int choice = Convert.ToInt32(Console.ReadLine);
                        if (choice == 1)
                        {
                            int meny = Convert.ToInt32(Console.ReadLine());
                            switch (meny)
                            {
                                case 1:
                                    TvPower();
                                    return true;
                                case 2:
                                    return false;
                                default: return true;

                            }
                        }



                    }
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
                            return true;
                        default: return true;

                    }

                    bool ChangeShow()
                    {
                        Console.WriteLine("Next chanel [1], Previous chanel [2]");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                television.chanel++;
                                Console.WriteLine(television.ChangeChanel());
                                return true;
                            case 2:
                                television.chanel--;
                                Console.WriteLine(television.ChangeChanel());
                                return true;
                        }
                        
                        return true;
                    }


                    void ChangeVolume()
                    {
                        Console.WriteLine("\n Volume down [1], Volume up [2].");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        ConsoleKeyInfo keyinfo;
                        Console.WriteLine("\n Press [X] to save volume. \n Press enter to keep changing volume");
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
                        Console.WriteLine($"Volume set to: {television.volume}");
                    }
                }
                







            }
        }
    }
}

