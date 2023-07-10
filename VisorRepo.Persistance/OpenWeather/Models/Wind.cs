using System.Text.Json.Serialization;

namespace VisorRepo.Persistance.OpenWeather.Models
{
    public class Wind
    {
        [JsonPropertyName("speed")]
        public float Speed { get; set; }
        [JsonPropertyName("deg")]
        public int Degree { get; set; }
    }
}
