using System.Collections;
using System.Text;
using System.Xml.Schema;

namespace T21_NewCD
{
    public class Song
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public Song(string name, double length)
        {
            Name = name;
            Length = length;
        }
    }
    public class CD : Song
    {
        public CD(string cdname, string artist, string name, double length) : base(name, length)
        {
            CDName = cdname;
            Artist = artist;
        }

        public string CDName { get; set; }
        public string Artist { get; set; }
        public int NumberOfSongs { get; private set; }
        public string TotalLength { get; private set; }
        // Count objects in Song Class
        public void Count(Song[] songs, double Total)
        {
            NumberOfSongs = songs.Length;
            var timeSpan = TimeSpan.FromMinutes(Total);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;
            TotalLength = $"***{hh}h {mm}m {ss}s***";
        }
        public override string ToString()
        {
            return $"You have CD: \n - Name: {CDName} \n - Artist: {Artist} \n - Total length: {TotalLength} \n - Number of Songs: {NumberOfSongs}\n";
        }
        public void GetSongs(ArrayList Songs)
        {
            for (int i = 0; i < Songs.Count; i++)
            {
                Console.WriteLine("\t" + Songs[i]);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("Endless Forms Most Beautiful", "Nighwish", "", default);
            Song[] songs = { new Song("Shudder Before the Beautiful", 6.29), new Song("Weak Fantasy", 5.23), new Song("Elan", 4.45), new Song("Yours Is an Empty Hope", 5.34), new Song("Our Decades in the Sun", 6.37), new Song("My Walden", 4.38), new Song("Endless Forms Most Beautiful", 5.07), new Song("Edema Ruh", 5.15), new Song("Alpenglow", 4.45), new Song("The Eyes of Sharbat Gula", 6.03), new Song("The Greatest Show on Earth", 24.00) };
            double Total = 0.00;
            ArrayList Songs = new ArrayList();
            foreach (Song song in songs)
            {
                Total += song.Length;
                Songs.Add("- " + song.Name + ", " + song.Length);
            }

            
            cd.Count(songs, Total);
            Console.WriteLine(cd.ToString());
            cd.GetSongs(Songs);
        }
    }
}