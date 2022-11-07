using System.Collections;
using System.ComponentModel;

namespace T26_SMLeague
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
            return $"Name: {Fname} {LName} Position: {GameLocation}, Number: {Number}";
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        List<Player> Players = new List<Player>();
        public Team(string team)
        {
            Name = team;
            if (team == "Jyp")
            {
                HomeTown = "Jyväskylä";
                Player[] Jyp_players = { new Player ("Mikko", "Petzman", "LW", 9), new Player ("Kyle", "Platzer", "C", 18), new Player("Topias", "Leinonen", "G", 34)};
                foreach (var player in Jyp_players)
                    Players.Add(player);
            }
            if (team == "Ilves")
            {
                HomeTown = "Tampere";
                Player[] Ilves_players = { new Player("Jakub", "Malek", "G", 31), new Player("Santeri", "Airola", "LD", 6), new Player("Eemeli", "Suomi", "LW", 10)};
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Team Jyp = new("Jyp");
            Jyp.showPlayers();

            Team Ilves = new("Ilves");
            Ilves.showPlayers();
        }
    }
}