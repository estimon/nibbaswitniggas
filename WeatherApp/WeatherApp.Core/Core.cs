using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string City)
        {
            string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + City +"&units=metric&appid="+ key;

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            var weather = new Weather();
            weather.Temperature = (string)results["main"]["temp"] + " C";
            weather.temp_max = (string)results["main"]["temp"] + " C";
            weather.temp_min = (string)results["main"]["temp"] + " C";

            return weather;
        }
    }
}
