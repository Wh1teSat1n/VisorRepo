using VisorRepo.Domain;
using System.Text.Json;

namespace VisorRepo.Application.Abstractions
{
    public abstract class WeatherService<T> where T : WeatherMapper<WeatherModel>
    {
        protected abstract string apiKey { get; }
        protected abstract string uri { get; }
        public abstract WeatherMapper<WeatherModel> WeatherMapper { get; }
        public abstract Task<WeatherModel> GetCurrentWeather(Location location);
    }
}
