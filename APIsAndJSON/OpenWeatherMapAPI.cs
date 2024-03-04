using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void GetWeatherByCity()
        {
            string apiKey = "33dc4d19b4bad9d4ab74f41ff2eae2fd"; //api key
            HttpClient client = new HttpClient(); //client

            Console.WriteLine("enter in a city");
            string cityName = Console.ReadLine();

            string weatherEndPoint = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial"; // endpoint

           string weatherResponse =  client.GetStringAsync(weatherEndPoint).Result;

            JObject weatherObject = JObject.Parse(weatherResponse);

            //Console.WriteLine(weatherObject);

            //to check just the temperature
            //Console.WriteLine(weatherObject["main"]["temp"]);

            // to give response ina sentense
            Console.WriteLine($"{cityName}'s temperature is {weatherObject["main"]["temp"]} degrees fahrenheit");
        }
    }
}
