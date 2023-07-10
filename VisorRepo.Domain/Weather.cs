

namespace VisorRepo.Domain
{
    public class Weather
    {
        public string Place { get; set; }
        public Location Location { get; set; }
        public float Temperature { get; set; }
        public int Pressure { get; set; }
        public string Condition { get; set; }
        public int Humidity { get; set; }        
        public int Visibility { get; set; }
        public string WindDirection { get; set; }
        public int WindDegree { get; set; }
        public float WindSpeed { get; set; }
    }
}
