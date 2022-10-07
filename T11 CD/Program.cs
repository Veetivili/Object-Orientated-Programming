namespace T11_CD
{
    public class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public string Song { get; set; }

        public List <string> AlbumSongs { get; set; } = new List <string> ();
        
        public CD(string artist, string album, string genre, double price)
        {
            Artist = artist;
            Album = album;
            Genre = genre;
            Price = price;
        }
        public string AllSongs()
        {
            return $" \n -- {AlbumSongs[0]} \n -- {AlbumSongs[1]} \n -- {AlbumSongs[2]} \n -- {AlbumSongs[3]}";
        }
        
        public string allData()
        {
            
            return $"\nArtist: {Artist} \nAlbum: {Album} \nGenre: {Genre} \nPrice: {Price}$ \n Songs: {AllSongs()}";

        }



                    internal class Program
                    {
                static void Main(string[] args)
                {


                    CD cd = new CD("Children of Bodom", "Hate Breeder", "Metal", 24.99);

                    cd.AlbumSongs.Add(cd.Song = "Warheart - 4.07");
                    cd.AlbumSongs.Add(cd.Song = "Silent Night, Bodom Night - 3.12");
                    cd.AlbumSongs.Add(cd.Song = "Hatebreeder - 4.20");
                    cd.AlbumSongs.Add(cd.Song = "Bed of Razors - 3.56");

                    Console.WriteLine(cd.allData());

                }
            }
        }    
    }
