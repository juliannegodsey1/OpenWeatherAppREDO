using Newtonsoft.Json.Linq;
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

            Console.WriteLine("What city would you like to check the weather?");
            var city = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;



            
        }



    }





}

