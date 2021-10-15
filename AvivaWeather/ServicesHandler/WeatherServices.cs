using System.Threading.Tasks;
using AvivaWeather.Models;
using AvivaWeather.WeatherRestClient;

namespace AvivaWeather.ServicesHandler
{
    public class WeatherServices : IWeatherServices
    {
        OpenWeatherMap<WeatherMainModel> _openWeatherRest = new OpenWeatherMap<WeatherMainModel>();
        public async Task<WeatherMainModel> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(city);
            return getWeatherDetails;
        }
    }
}