using System.Text.Json.Serialization;

namespace WeatherDashboard.Models
{
    public class WeatherViewModel
    {
        [JsonPropertyName("name")]
        public string CityName { get; set; }

        [JsonPropertyName("main")]
        public MainData Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonPropertyName("wind")]
        public WindData Wind { get; set; }

        public string WeatherCondition => Weather?.FirstOrDefault()?.MainCondition ?? "Clear";
        public string Description => Weather?.FirstOrDefault()?.Detail ?? "";
        public string IconCode => Weather?.FirstOrDefault()?.Icon ?? "01d";
    }

    public class MainData
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherDescription
    {
        [JsonPropertyName("main")]
        public string MainCondition { get; set; }

        [JsonPropertyName("description")]
        public string Detail { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class WindData
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }
}