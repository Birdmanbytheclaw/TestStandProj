using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        public string condition;
        public string forecast;
        public int temperature;
        public List<string> weatherConditions;
        private Random randForWeather = new Random();


        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Foggy", "Windy", "Rainy" };
            
        }

        public void SetWeatherCondition()
        {
            int pick = randForWeather.Next(0, 4);
            condition = weatherConditions[pick];

            switch (pick)
            {
                case 0:
                    temperature = randForWeather.Next(75, 90);
                    break;
                case 1:
                    temperature = randForWeather.Next(55, 75);
                    break;
                case 2:
                    temperature = randForWeather.Next(50, 75);
                    break;
                case 3:
                    temperature = randForWeather.Next(48, 65);
                    break;
                case 4:
                    temperature = randForWeather.Next(48, 85);
                    break;
            }
        }

        public void PredictedForecast()
        {
            forecast = weatherConditions[randForWeather.Next(0, 4)];
            Console.WriteLine("Forecast for tomorrow: " + forecast);
        }

    }
}
