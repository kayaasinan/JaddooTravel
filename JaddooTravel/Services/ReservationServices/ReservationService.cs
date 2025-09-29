using AutoMapper;
using JaddooTravel.Dtos.ReservationDtos;
using JaddooTravel.Entities;
using JaddooTravel.Settings;
using MongoDB.Driver;

namespace JaddooTravel.Services.ReservationServices
{
    public class ReservationService : IReservationService
    {
        private readonly IMongoCollection<Reservation> _reservationCollection;
        private readonly IMapper _mapper;

        public ReservationService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _reservationCollection = database.GetCollection<Reservation>(databaseSettings.ReservationCollectionName);
            _mapper = mapper;
        }

        public async Task CreateReservationAsync(CreateReservationDto createReservationDto)
        {
            var reservation = _mapper.Map<Reservation>(createReservationDto);
            await _reservationCollection.InsertOneAsync(reservation);
        }

        public async Task DeleteReservationAsync(string id)
        {
            await _reservationCollection.DeleteOneAsync(r => r.ReservationId == id);
        }

        public async Task<List<ResultReservationDto>> GetAllReservationAsync()
        {
            var reservations = await _reservationCollection.Find(r => true).ToListAsync();
            return _mapper.Map<List<ResultReservationDto>>(reservations);
        }

        public async Task<GetReservationByIdDto> GetReservationByIdAsync(string id)
        {
            var reservation = await _reservationCollection.Find(r => r.ReservationId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetReservationByIdDto>(reservation);
        }

        public async Task UpdateReservationAsync(UpdateReservationDto updateReservationDto)
        {
            var updated = _mapper.Map<Reservation>(updateReservationDto);
            await _reservationCollection.FindOneAndReplaceAsync(r => r.ReservationId == updateReservationDto.ReservationId, updated);
        }
    }
}