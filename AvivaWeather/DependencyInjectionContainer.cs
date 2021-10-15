using System;
using AvivaWeather.ServicesHandler;
using AvivaWeather.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvivaWeather
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherServices, WeatherServices>();
            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<WeatherViewModel>();
            return services;
        }
    }
}
