using VisorRepo.Domain;
using System.Text.Json;

namespace VisorRepo.Application.Abstractions
{
    public abstract class WeatherService
    {
        protected abstract string apiKey { get; }
        protected abstract string uri { get; }
        public abstract Task<string> GetCurrentWeather(Location location);
    }
}
