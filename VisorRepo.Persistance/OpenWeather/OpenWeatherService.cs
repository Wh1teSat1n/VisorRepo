using VisorRepo.Application.Abstractions;
using VisorRepo.Domain;
using VisorRepo.Persistance.OpenWeather.Models;
using VisorRepo.Persistance.Desirializers;

namespace VisorRepo.Persistance.OpenWeather
{
    public class OpenWeatherService : WeatherService
    {                
        protected override string apiKey => "0e36766f7f628f6acde426bdd92810ab";
        protected override string uri => "https://api.openweathermap.org/data/2.5/weather";
        protected IDesirealizer desirealizer;
        public override OpenWeatherMapper WeatherMapper { get; }        

        public OpenWeatherService(IDesirealizer desirealizer, OpenWeatherMapper weatherMapper)
        {
            this.desirealizer = desirealizer;
            this.WeatherMapper = weatherMapper;
        }

        public async override Task<WeatherModel> GetCurrentWeather(Location location)
        {
            string weatherJson = await GetCurrentWeatherAsJson(location);
            var weather = await desirealizer.Deserialize(weatherJson) as OpenWeatherModel;

            return weather;
        }     
        private async Task<string> GetCurrentWeatherAsJson(Location location)
        {
            using var client = new HttpClient();

            string requestUri = $"{this.uri}?lat={location.Latitude}&lon={location.Longitude}&appid={apiKey}";            
            
            var response = await client.GetStringAsync(requestUri);

            Console.WriteLine(response.ToString());

            return response;
        }        
    }
}
