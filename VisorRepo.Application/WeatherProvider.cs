using VisorRepo.Domain;
using VisorRepo.Application.Abstractions;

namespace VisorRepo.Application
{
    public class WeatherProvider
    {        
        protected WeatherService _weatherService;                

        public WeatherProvider(WeatherService service)
        {
            _weatherService = service;            
        }

        public async Task<Weather> GetWeatherAsync(Location location)
        {
            WeatherModel model = await _weatherService.GetCurrentWeather(location);
            Weather weather = _weatherService.WeatherMapper.Map();

            return weather;
        }
    }
}
