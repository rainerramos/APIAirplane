namespace ADN.Domain.Domain
{
    public class Airplane
    {

        public string Model { get; set; }
        public string Color { get; set; }
        public TimeOnly FlightHours { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public int Height { get; set; }
    }
}
