using System;
using System.Collections.Generic;
using AvivaWeather.ViewModels;
using Xamarin.Forms;

namespace AvivaWeather.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(WeatherViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
