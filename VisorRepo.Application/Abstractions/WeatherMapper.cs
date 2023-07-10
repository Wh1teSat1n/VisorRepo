using VisorRepo.Domain;

namespace VisorRepo.Application.Abstractions
{
    public abstract class WeatherMapper<T> where T : WeatherModel
    {
        protected abstract T model { get; }
        public abstract Weather Map();
        public abstract Weather Map(T weather);
    }
}
