using VisorRepo.Application.Abstractions;
using VisorRepo.Domain;
using VisorRepo.Persistance.OpenWeather.Models;
using VisorRepo.Persistance.Desirializers;

namespace VisorRepo.Persistance.Models.OpenWeather
{
    public class OpenWeatherService : WeatherService
    {                
        protected override string apiKey => "0e36766f7f628f6acde426bdd92810ab";
        protected override string uri => "https://api.openweathermap.org/data/2.5/weather";
        protected IDesirealizer desirealizer;

        public OpenWeatherService(IDesirealizer desirealizer)
        {
            this.desirealizer = desirealizer;
        }

        public async override Task<WeatherModel> GetCurrentWeather(Location location)
        {
            Stream weatherJson = await GetCurrentWeatherAsJson(location);
            MainWeatherModel weather = await desirealizer.Deserialize(weatherJson);

            return weather;
        }     
        private async Task<Stream> GetCurrentWeatherAsJson(Location location)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, uri);

            request.Headers.Add("lat", location.Latitude.ToString());
            request.Headers.Add("lon", location.Longitude.ToString());

            var response = await client.SendAsync(request);

            return await response.Content.ReadAsStreamAsync();
        }        
    }
}
