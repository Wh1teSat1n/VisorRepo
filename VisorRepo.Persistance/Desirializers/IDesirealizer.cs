using VisorRepo.Application.Abstractions;

namespace VisorRepo.Persistance.Desirializers
{
    public interface IDesirealizer
    {
        Task<WeatherModel> Deserialize(string weatherJson);
    }
}
