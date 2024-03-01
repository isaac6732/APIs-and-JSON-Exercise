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
        public static void GetWeather()
        {
            var  apiKey = "3e1aca0b70ea6d4beae468c8bd63808e";
           
            var client = new HttpClient();
            
            var cityName = "New York";
            
            var weatherEndpoint = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
           
            string weatherResponse = client.GetStringAsync(weatherEndpoint).Result;
            
            var weatherObject = JObject.Parse(weatherResponse);
            Console.WriteLine(weatherObject);
            
            //Note: Usa el string $ {} con sus valores para mirar solos los valores que quieres ver del API en el CW.
            //Note:Usa el userInput para que diga la ciudad y el API dara las temperatura de la ciudad que el elija 17,18 pon el codigo.
        }
    }
}
