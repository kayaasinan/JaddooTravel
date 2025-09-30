using JaddooTravel.Dtos.SnapshotsDtos;
using JaddooTravel.Entities;
using JaddooTravel.Settings;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace JaddooTravel.Services.SnapshotServices
{
    public class SnapshotService : ISnapshotService
    {
        private readonly IMongoCollection<Destination> _destinations;
        private readonly IMongoCollection<Reservation> _reservations;

        public SnapshotService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var db = client.GetDatabase(settings.DatabaseName);

            _destinations = db.GetCollection<Destination>(settings.DestinationCollectionName);
            _reservations = db.GetCollection<Reservation>(settings.ReservationCollectionName);
        }

        public async Task<GraficDestinationDto> GetGraficDataAsync()
        {
            var destList = await _destinations.AsQueryable().ToListAsync();
            var resList = await _reservations.AsQueryable().ToListAsync();

            var dto = new GraficDestinationDto
            {
                CityCountry = destList.Select(x => x.CityCountry).ToList(),
                Capacity = destList.Select(x => x.Capacity).ToList(),
                Price = destList.Select(x => x.Price).ToList()
            };

            var values = (from r in resList
                           join d in destList on r.DestinationId equals d.DestinationId
                           select d.Price).Sum();

            dto.TotalRevenue = values;

            return dto;
        }
    }
}
