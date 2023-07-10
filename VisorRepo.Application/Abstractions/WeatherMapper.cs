using VisorRepo.Domain;

namespace VisorRepo.Application.Abstractions
{
    public abstract class WeatherMapper
    {
        protected abstract WeatherModel model { get; }
        public abstract Weather Map();        
    }
}
