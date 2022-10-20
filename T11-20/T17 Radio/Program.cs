using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace T17_Radio
{
    public class Electrical_Device
    {
        public bool ON { get; set; } = false;
        public float Power { get; set; }
        public Electrical_Device(bool on, float power)
        {
            ON = on;
            Power = power;
        }

    }
    public class Portable_Radio : Electrical_Device
    {
        // Properties
        public int Volume { get; set; } = 0;
        public double Frequency { get; set; } = 0;
        // Constructor
        public Portable_Radio(int volume, double frequency, bool on, float power) : base(on, power)
        {
            Volume = volume;
            Frequency = frequency;
        }
        // Methods
        public override string ToString()
        {
            string status = $"\nRadio is On: {ON} \nPower is: {Power}W \nChanel is: {Frequency} \nVolume is: {Volume}";
            return status;
        }
        public void OnSwitch()
        {
            if (ON==false)
            {
                ON = true;
                Power = 200;
                Console.WriteLine("Powering on Radio...");
            }
        }
        public string ChangeVolume(int value)
        {
            if (ON == false)
            {
                return "Can't change volume, when radio is off.";
            }
            else if (value < 0 || value > 9)
            {
                
                return $"Volume can't be set in out of the range (0-9), your choice: {value}";
            }
            Volume = value;
            return $"Volume is set to {Volume}";
        }
        public string ChangeFrequency(double freq)
        {
            if (ON == false)
            {
                
                return "Can't change chanel, when radio is off.";
            }
            else if (freq < 2000.00 || freq > 2600.00)
            {
                return $"Chanel can't be set in out of the range (2000.00-2600.00), your choice: {freq}";
            }
            Frequency = freq;
            return $"Chanel frequency is set to: {Frequency}";


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining radio object and printing all information
            Portable_Radio radio = new Portable_Radio(0, 0, false, 0);
            Console.WriteLine(radio.ToString());
            
            // Testing different volume changes
            int value = -2;
            Console.WriteLine(radio.ChangeVolume(value));
            Console.WriteLine(radio.ToString());

            // Turn on Radio and keep setting volumes;
            radio.OnSwitch();
            Console.WriteLine(radio.ToString());

            value = -4;
            Console.WriteLine(radio.ChangeVolume(value));
            Console.WriteLine(radio.ToString());

            value = 11;
            Console.WriteLine(radio.ChangeVolume(value));
            Console.WriteLine(radio.ToString());

            value = 6;
            Console.WriteLine(radio.ChangeVolume(value));
            Console.WriteLine(radio.ToString());

            // Testing different chanels
            double freq = 2400.00;
            Console.WriteLine(radio.ChangeFrequency(freq));
            Console.WriteLine(radio.ToString());

            freq = 1999.00;
            Console.WriteLine(radio.ChangeFrequency(freq));
            Console.WriteLine(radio.ToString());

            freq = 2999.00;
            Console.WriteLine(radio.ChangeFrequency(freq));
            Console.WriteLine(radio.ToString());
        }
    }
}