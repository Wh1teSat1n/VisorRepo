using VisorRepo.Application.Abstractions;
using VisorRepo.Domain;
using System.Text.Json;

namespace VisorRepo.Persistance.Models
{
    public class OpenWeatherService : WeatherService
    {                
        protected override string apiKey => "0e36766f7f628f6acde426bdd92810ab";
        protected override string uri => "https://api.openweathermap.org/data/2.5/weather";

        public async override Task<string> GetCurrentWeather(Location location)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, uri);
            
            request.Headers.Add("lat", location.Latitude.ToString());
            request.Headers.Add("lon", location.Longitude.ToString());

            var response = await client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();
        }     
        private Weather Convert(string weatherJson)
        {
            var weather = JsonSerializer.Deserialize<Weather>(weatherJson);
        }
    }
}
