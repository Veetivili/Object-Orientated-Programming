using System.Runtime.CompilerServices;
using System.Text;

namespace T27_SMLeagueExport
{
    public class Player
    {
        public string Fname { get; set; }
        public string LName { get; set; }
        public string GameLocation { get; set; }
        public int Number { get; set; }
        public Player(string fname, string lName, string gameLocation, int number)
        {
            Fname = fname;
            LName = lName;
            GameLocation = gameLocation;
            Number = number;
        }
        public override string ToString()
        {
            return $"Name:{Fname};{LName};Position:{GameLocation};Number:{Number};";
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        List<object> Players = new List<object>();
        public Team(string team)
        {
            Name = team;
            if (team == "Jyp")
            {
                HomeTown = "Jyväskylä";
                Player[] Jyp_players = { new Player("Mikko", "Petzman", "LW", 9), new Player("Kyle", "Platzer", "C", 18), new Player("Topias", "Leinonen", "G", 34) };
                foreach (var player in Jyp_players)
                    Players.Add(player);
            }
            if (team == "Ilves")
            {
                HomeTown = "Tampere";
                Player[] Ilves_players = { new Player("Jakub", "Malek", "G", 31), new Player("Santeri", "Airola", "LD", 6), new Player("Eemeli", "Suomi", "LW", 10) };
                foreach (var player in Ilves_players)
                    Players.Add(player);
            }
        }
        public void showPlayers()
        {
            Console.WriteLine($"\nTeam: {Name} - Hometown: {HomeTown}, Players: ");
            foreach (var player in Players)
                Console.WriteLine($"\t{player}");
        }
        public void WritePlayersCsv()
        {
            string Filename = Name;
            var Filepath = $"D:\\School\\Year 2 - Autumn 2022\\Object orientated programming\\ttc8440\\T21-30\\T27 SMLeagueExport\\{Filename}.csv";
            var csv = new StringBuilder();
            foreach (var player in Players)
            {
                string csvformat1 = player.ToString().Replace("Name:","");
                string csvformat2 = csvformat1.Replace("Position:","");
                string csvformat3 = csvformat2.Replace("Number:","");
                csv.AppendLine(csvformat3.ToString());
            }
            File.WriteAllText(Filepath, csv.ToString());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Team Jyp = new("Jyp");
            Jyp.showPlayers();

            Team Ilves = new("Ilves");
            Ilves.showPlayers();

            Jyp.WritePlayersCsv();
            Ilves.WritePlayersCsv();

        }
    }
}