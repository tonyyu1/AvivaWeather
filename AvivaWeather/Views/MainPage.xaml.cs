using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvivaWeather.ViewModels;
using Xamarin.Forms;

namespace AvivaWeather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
    }
}
