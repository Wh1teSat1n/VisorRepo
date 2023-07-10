using VisorRepo.Domain;
using VisorRepo.Application.Abstractions;

namespace VisorRepo.Application
{
    public class WeatherProvider
    {        
        protected WeatherService<WeatherMapper<WeatherModel>> _weatherService;                

        public WeatherProvider(WeatherService<WeatherMapper<WeatherModel>> service)
        {
            _weatherService = service;            
        }

        public async Task<Weather> GetWeatherAsync(Location location)
        {
            WeatherModel model = await _weatherService.GetCurrentWeather(location);
            Weather weather = _weatherService.WeatherMapper.Map(model);

            return weather;
        }
    }
}
