using System.Text.Json.Serialization;

namespace VisorRepo.Persistance.OpenWeather.Models
{
    public class CommonWeatherData
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }
}
