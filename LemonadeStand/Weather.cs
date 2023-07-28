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
        public string WeatherCondition { get; set; }

        public void GenereateForecast()
        {
            Random random = new Random();
            Temperature = random.Next(50, 90); //This is random temperature between 50 degrees Fahreheit to 89 degrees Fahrenheit

            // Used to select a random weather conditon
            string[] weatherCondition = { "Sunny", "Partly Cloudy", "Scattered Thunderstorms" };
            int randomIndex = random.Next(weatherCondition.Length);
            WeatherCondition = weatherCondition[randomIndex];
        }

        public void DisplayForecast()
        {
            Console.WriteLine($"The Forecast for today is:");
            Console.WriteLine($"Temperature: {Temperature} {(char)176}F");
            Console.WriteLine($"Condition: {WeatherCondition}");
        }
        
        public Weather GetWeatherForecast()
        {
            Random random = new Random();
            string[] weatherConditions = { "Sunny", "Partly Cloudy", "Scattered Thunderstorms" };
            int temperature = random.Next(50, 90); //This is random temperature between 50 degrees Fahreheit to 89 degrees Fahrenheit
            string condition = weatherConditions[random.Next(weatherConditions.Length)];
            
            return new Weather { Temperature = temperature, WeatherCondition = condition }; 
        }

    }
    
}
