namespace T14_Amplifier
{
   
    internal class Program
    {
        public class Amplifier
        {
            public int CurrentVolume { get; private set; }
            public void ChangeVolume(int volume, out string message)
            {
                Console.WriteLine("Give a new volume value (0-100)");
                if (volume < 0)
                {
                    CurrentVolume = 0;
                    message = $"{volume}\nToo low volume - Amplifier volume is set to minimum: {CurrentVolume}";
                }
                else if (volume > 100)
                {
                    CurrentVolume = 100;
                    message = $"{volume}\nToo big Volume - Amplifier volume is set to maximum: {CurrentVolume}";
                }
                else
                {
                    CurrentVolume = volume;
                    message = $"{volume}\nAmplifier Volume is set to: {CurrentVolume}";
                }
            }
        }

        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            string message = "";
            Console.WriteLine($"Volume is now: {amplifier.CurrentVolume}");
            int volume = 100;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);
            volume = 40;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);
            volume = 0;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);
            volume = -10;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);
            volume = 200;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);
            volume = 35;
            amplifier.ChangeVolume(volume, out message);
            Console.WriteLine(message);


        }
    }
}