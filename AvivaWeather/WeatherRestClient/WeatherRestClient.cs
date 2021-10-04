using AvivaWeather.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AvivaWeather.WeatherRestClient
{
    public class OpenWeatherMap<T>
    {
        private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string Key = "432237c749d6787e53073308360bb7a3";
        HttpClient _httpClient = new HttpClient();

        public async Task<T> GetAllWeathers(string city)
        {
            try
            {
                var json = await _httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key);
                var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
                return getWeatherModels;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}