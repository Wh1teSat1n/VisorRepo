

namespace VisorRepo.Domain
{
    public class Weather
    {
        public Location Location { get; set; }
        public float Temperature { get; set; }
        public string Condition { get; set; }
        public int Humidity { get; set; }        
        public string WindDirection { get; set; }
        public int WindSpeed { get; set; }
    }
}
