

namespace VisorRepo.Domain
{
    public class Weather
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Temperature { get; set; }
        public string Condition { get; set; }
        public int Humidity { get; set; }        
        public string WindDirection { get; set; }
        public int WindSpeed { get; set; }
    }
}
