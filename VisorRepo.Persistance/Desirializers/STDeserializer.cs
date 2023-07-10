using System.Text.Json;
using VisorRepo.Application.Abstractions;
using VisorRepo.Persistance.OpenWeather.Models;

namespace VisorRepo.Persistance.Desirializers
{
    public class STDeserializer : IDesirealizer
    {
        public async Task<WeatherModel> Deserialize(Stream stream)
        {
            return await JsonSerializer.DeserializeAsync<OpenWeatherModel>(stream);
        }
    }
}
