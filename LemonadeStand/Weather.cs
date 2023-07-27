using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {

        public int Temperature { get; set; }
        public string Condition { get; set; }

        public void GenereateForecase()
        {
            Random random = new Random();
            Temperature = random.Next(50, 90); //This is random temperature between 50 degrees Fahreheit to 89 degrees Fahrenheit

            // Used to select a random weather conditon
            string[] weatherCondition = { "Sunny", "Partly Cloudy", "Scattered Thunderstorms" };
            int randomIndex = random.Next(weatherCondition.Length);
            Condition = weatherCondition[randomIndex];
        }

        public void DisplayForecast()
        {
            Console.WriteLine($"The Forecast for today is:");
            Console.WriteLine($"Temperature: {Temperature} {(char)176}F");
            Console.WriteLine($"Condition: {Condition}");
        }
        

    }
    
}
