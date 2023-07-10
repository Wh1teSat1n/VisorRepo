using VisorRepo.Domain;
using VisorRepo.Application.Abstractions;
using VisorRepo.Persistance.OpenWeather.Models;

namespace VisorRepo.Persistance.OpenWeather
{
    public class OpenWeatherMapper : WeatherMapper
    {
        protected override OpenWeatherModel model { get; }
        public OpenWeatherMapper(OpenWeatherModel model)
        {            
            this.model = model;
        }        
        public override Weather Map()
        {
            var weather = new Weather()
            {
                Place = model.Place,
                Location = new Location()
                {
                    Latitude = model.Location.Latitude,
                    Longitude = model.Location.Longitude
                },
                Temperature = model.CommonWeatherData.Temp,
                Pressure = model.CommonWeatherData.Pressure,
                Condition = model.Condition[0].Desctription,
                Humidity = model.CommonWeatherData.Humidity,
                Visibility = model.Visibility,
                WindDegree = model.Wind.Degree,
                WindSpeed = model.Wind.Speed
            };

            return weather;
        }        
    }
}
