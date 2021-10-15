using System;
using AvivaWeather.ServicesHandler;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvivaWeather
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceProvider Init()
        {
            var serviceProvider = new ServiceCollection()
                .ConfigureServices()
                .ConfigureViewModels()
                .BuildServiceProvider();

            ServiceProvider = serviceProvider;
            return serviceProvider;
        }

        public App()
        {
            InitializeComponent();
            Init();
            MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
