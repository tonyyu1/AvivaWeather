using Newtonsoft.Json;
using System;
using Xamarin.Forms;

namespace AvivaWeather
{
    public static class AppSettings
    {
        private const string keyCity = "city";


        private static object GetKey(string key)
        {
            object result = null;
            if (Application.Current.Properties.ContainsKey(key))
                result = Application.Current.Properties[key];

            return result;
        }

        public static void SetKey(string key, object value)
        {
            Application.Current.Properties[key] = value;
            Application.Current.SavePropertiesAsync();
        }


        public static string City
        {
            get
            {
                object result = GetKey(keyCity);
                if (result != null)
                    return result.ToString();
                else
                    return String.Empty;
            }

            set
            {
                SetKey(keyCity, value);
            }
        }


        public static int GetInt(string keyInt)
        {
            object result = GetKey(keyInt);
            if ((result != null) && (result.GetType() == typeof(int)))
                return (int)result;
            else
                return 0;
        }

        public static long GetLong(string keyLong)
        {
            object result = GetKey(keyLong);
            if ((result != null) && (result.GetType() == typeof(long)))
                return (long)result;
            else
                return 0;
        }

        public static double GetDouble(string keyDouble)
        {
            object result = GetKey(keyDouble);
            if ((result != null) && (result.GetType() == typeof(double)))
                return (double)result;
            else
                return 0;
        }

        public static bool GetBool(string keyInt)
        {
            object result = GetKey(keyInt);
            if ((result != null) && (result.GetType() == typeof(bool)))
                return (bool)result;
            else
                return false;
        }

        public static string GetString(string keyString)
        {
            object result = GetKey(keyString);
            if ((result != null) && (result.GetType() == typeof(string)))
                return (string)result;
            else
                return string.Empty;
        }
    }
}
