namespace JaddooTravel.Dtos.SnapshotsDtos
{
    public class GraficDestinationDto
    {
        public List<string> CityCountry { get; set; } = new();
        public List<int> Capacity { get; set; } = new();
        public List<decimal> Price { get; set; } = new();
        public decimal TotalRevenue { get; set; }
    }
}
