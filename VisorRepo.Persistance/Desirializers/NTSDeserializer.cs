using Newtonsoft.Json;
using VisorRepo.Application.Abstractions;

namespace VisorRepo.Persistance.Desirializers
{
    public class NTSDeserializer : IDesirealizer
    {
        public Task<WeatherModel> Deserialize(string weatherJson)
        {
            return Task.FromResult(JsonConvert.DeserializeObject<WeatherModel>(weatherJson));            
        }
    }
}
