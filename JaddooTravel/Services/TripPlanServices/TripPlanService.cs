using AutoMapper;
using JaddooTravel.Dtos.TripPlanDtos;
using JaddooTravel.Entities;
using JaddooTravel.Settings;
using MongoDB.Driver;

namespace JaddooTravel.Services.TripPlanServices
{
    public class TripPlanService : ITripPlanService
    {
        private readonly IMongoCollection<TripPlan> _tripPlanCollection;
        private readonly IMapper _mapper;

        public TripPlanService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _tripPlanCollection = database.GetCollection<TripPlan>(_databaseSettings.TripPlanCollectionName);
            _mapper = mapper;
        }

        public async Task CreateTripPlanAsync(CreateTripPlanDto createTripPlanDto)
        {
            var values = _mapper.Map<TripPlan>(createTripPlanDto);
            await _tripPlanCollection.InsertOneAsync(values);
        }

        public async Task DeleteTripPlanAsync(string id)
        {
            await _tripPlanCollection.DeleteOneAsync(id);
        }

        public async Task<List<ResultTripPlanDto>> GetAllTripPlanAsync()
        {
            var values = await _tripPlanCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultTripPlanDto>>(values);
        }

        public async Task<GetTripPlanByIdDto> GetTripPlanByIdAsync(string id)
        {
            var values = await _tripPlanCollection.Find(x => x.TripPlanId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetTripPlanByIdDto>(values);
        }

        public async Task UpdateTripPlanAsync(UpdateTripPlanDto updateTripPlanDto)
        {
            var values = _mapper.Map<TripPlan>(updateTripPlanDto);
            await _tripPlanCollection.FindOneAndReplaceAsync(x => x.TripPlanId == updateTripPlanDto.TripPlanId, values);
        }
    }
}
