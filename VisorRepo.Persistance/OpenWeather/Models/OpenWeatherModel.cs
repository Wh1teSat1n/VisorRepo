using VisorRepo.Application.Abstractions;
using System.Text.Json.Serialization;

namespace VisorRepo.Persistance.OpenWeather.Models
{
    public class OpenWeatherModel : WeatherModel
    {
        [JsonPropertyName("name")]
        public string Place { get; set; }
        [JsonPropertyName("coord")]
        public LocationModel Location { get; set; }        
        [JsonPropertyName("weather")]
        public Condition[] Condition { get; set; }
        [JsonPropertyName("main")]
        public CommonWeatherData CommonWeatherData { get; set; }
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
    }
}
