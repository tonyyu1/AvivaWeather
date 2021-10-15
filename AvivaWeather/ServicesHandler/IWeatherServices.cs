using System.Threading.Tasks;
using AvivaWeather.Models;

namespace AvivaWeather.ServicesHandler
{
    public interface IWeatherServices
    {
        Task<WeatherMainModel> GetWeatherDetails(string city);
    }
}