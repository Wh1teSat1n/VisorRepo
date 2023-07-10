using System.Text.Json.Serialization;

namespace VisorRepo.Persistance.OpenWeather.Models
{
    public class Condition
    {
        [JsonPropertyName("description")]
        public string Desctription { get; set; }
    }
}
