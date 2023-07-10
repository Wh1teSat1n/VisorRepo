using System.Text.Json;
using VisorRepo.Application.Abstractions;
using VisorRepo.Persistance.OpenWeather.Models;

namespace VisorRepo.Persistance.Desirializers
{
    public class STDeserializer : IDesirealizer
    {
        public async Task<WeatherModel> Deserialize(string weatherJson)
        {
            //return await JsonSerializer.DeserializeAsync<OpenWeatherModel>(weatherJson);
            return null;
        }
    }
}
