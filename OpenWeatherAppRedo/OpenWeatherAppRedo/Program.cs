﻿using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace OpenWeatherAppREDO
{
    public class Program
    {
        static void Main(string[] args)
        {


            var client = new HttpClient();

            Console.WriteLine("Please enter your API Key:");
            var key = Console.ReadLine();

            Console.WriteLine("What zipcode would you like to check the weather for?");
            var zipCode = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={key}&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;

            JObject formattedResponse = JObject.Parse(response);
            var weather = formattedResponse.GetValue("main").ToString();
            var temp = JObject.Parse(weather).GetValue("temp");


            Console.WriteLine($"The temperature in {zipCode} is {temp} degrees Fahrenheit.");





            
        }



    }





}

