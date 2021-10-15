using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AvivaWeather.Models
{
    public class WeatherMainModel
    {
        [JsonProperty("name")]
        public string name { get; set; }
        public WeatherTempDetails main { get; set; }
        public List<WeatherSubDetails> weather { get; set; }
        public WeatherWindDetails wind { get; set; }
        public WeatherSysDetails sys { get; set; }
    }

    public class WeatherSubDetails
    {
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public class WeatherSysDetails
    {
        [JsonProperty("country")]
        public string country { get; set; }
    }

    public class WeatherTempDetails
    {
        private string _temp;
        public string temp
        {
            get
            {
                double finalTemp = (Convert.ToDouble(_temp) - 273.15);
                return finalTemp.ToString("N1") + "°C";
            }
            set
            {
                _temp = value;
            }
        }
        [JsonProperty("humidity")]
        public string humidity { get; set; }
    }

    public class WeatherWindDetails
    {
        [JsonProperty("speed")]
        public string speed { get; set; }
    }
}