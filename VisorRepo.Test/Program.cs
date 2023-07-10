using VisorRepo.Application;
using VisorRepo.Persistance.OpenWeather;
using VisorRepo.Persistance.Desirializers;
using VisorRepo.Persistance.OpenWeather.Models;
using VisorRepo.Domain;

namespace VisorRepo.Tests;

public class Test
{
    public static async Task Main(string[] args)
    {
        OpenWeatherService service = new OpenWeatherService(new NTSDeserializer(), 
            new OpenWeatherMapper(new OpenWeatherModel()));
        var provider = new WeatherProvider(service);
        
        Location peski = new Location()
        {
            Latitude = 53.674,
            Longitude = 23.842      
        };

        var weather = await provider.GetWeatherAsync(peski);

        Print(weather);
    }

    public static void Print(Weather weather)
    {
        Console.WriteLine(weather.Place);
        Console.WriteLine(weather.Temperature);
        Console.WriteLine(weather.Condition);
        Console.WriteLine(weather.Humidity);
        Console.WriteLine(weather.Pressure);
    }
}