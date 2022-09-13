using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPrimer_Challenge_2
{
    class WeatherData
    {
        public WeatherData(int t, int h, string s, string c)
        {
            Temperature = t;
            Humidity = h;
            Scale = s;
        }

        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Scale { get; set; }
        public string ConvertScale { get; set; }
            
        public void Celsius()
        {
            Scale = "C";
        }
        public void Fahrenheit()
        {
            Scale = "F";
        }
        public void Convert()
        {
            Console.WriteLine("Please hit enter to convert form celsius to fahrenheit or fahrenheit to celsius.");
            while (true)
            {
                ConvertScale = Console.ReadLine();

                if (ConvertScale == "" && Scale == "C")
                {
                    Scale = "F";
                    Temperature = (Temperature * 9) / 5 + 32;
                    Console.WriteLine($"The current temperature is {Temperature}°{Scale} with {Humidity}% humidity");
                } else if (ConvertScale == "" && Scale == "F")
                {
                    Scale = "C";
                    Temperature = (Temperature - 32) * 5 / 9;
                    Console.WriteLine($"The current temperature is {Temperature}°{Scale} with {Humidity}% humidity");
                } else if (ConvertScale == "Exit" || ConvertScale == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please hit enter to change scale or 'Exit' to quit program");
                }


            }
            
        }
}
}
