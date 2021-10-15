using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvivaWeather.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;

namespace AvivaWeather.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService<WeatherViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((WeatherViewModel)BindingContext).Init();
        }

        void SaveCity_Clicked(System.Object sender, System.EventArgs e)
        {
            ((WeatherViewModel)BindingContext).SaveCity();
        }

        void WeatherDetail_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage((WeatherViewModel)BindingContext));
        }
    }
}
