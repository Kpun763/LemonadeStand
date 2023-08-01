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

        private static readonly Random random = new Random();   
        public void GenerateForecast()
        {
            Random random = new Random();
            Temperature = random.Next(50, 90); //This is random temperature between 50 degrees Fahreheit to 89 degrees Fahrenheit

            // Used to select a random weather conditon
            string[] weatherCondition = { "Sunny", "Partly Cloudy", "Scattered Thunderstorms" };
            int randomIndex = random.Next(weatherCondition.Length);
            WeatherCondition = weatherCondition[randomIndex];
        }

        public void DisplayForecast() //I created to display forecast
        {
            Console.WriteLine($"The Forecast for today is:");
            Console.WriteLine($"Temperature: {Temperature} {(char)176}F");
            Console.WriteLine($"Condition: {WeatherCondition}");
        }
        
        public static Weather GetWeatherForecast() //I created to help determine the demand for the lemonade
        {
           
            string[] weatherConditions = { "Sunny", "Partly Cloudy", "Scattered Thunderstorms" };
            int temperature = random.Next(50, 90); //This is random temperature between 50 degrees Fahreheit to 89 degrees Fahrenheit
            int randomIndex = random.Next(weatherConditions.Length);
            string condition = weatherConditions[randomIndex];
            
            return new Weather { Temperature = temperature, WeatherCondition = condition }; 
        }

    }
    
}
