using AutoMapper;
using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Entities;
using JaddooTravel.Settings;
using MongoDB.Driver;

namespace JaddooTravel.Services.DestinationServices
{
    public class DestinationService : IDestinationService
    {
        private readonly IMongoCollection<Destination> _destinationCollection;
        private readonly IMapper _mapper;

        public DestinationService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client=new MongoClient(_databaseSettings.ConnectionString);
            var database=client.GetDatabase(_databaseSettings.DatabaseName);
            _destinationCollection=database.GetCollection<Destination>(_databaseSettings.DestinationCollectionName);
            _mapper = mapper;
        }

        public async Task CreateDestinationAsync(CreateDestinationDto createDestinationDto)
        {
            var values=_mapper.Map<Destination>(createDestinationDto);
            await _destinationCollection.InsertOneAsync(values);
        }

        public async Task DeleteDestinationAsync(string id)
        {
            await _destinationCollection.DeleteOneAsync(id);
        }

        public async Task<List<ResultDestinationDto>> GetAllDestinationAsync()
        {
            var values = await _destinationCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultDestinationDto>>(values);
        }

        public async Task<GetDestinationByIdDto> GetDestinationByIdAsync(string id)
        {
            var values = await _destinationCollection.Find(x => x.DestinationId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetDestinationByIdDto>(values);
        }

        public async Task UpdateDestinationAsync(UpdateDestinationDto updateDestinationDto)
        {
            var values = _mapper.Map<Destination>(updateDestinationDto);
            await _destinationCollection.FindOneAndReplaceAsync(x=>x.DestinationId == updateDestinationDto.DestinationId, values);
        }
    }
}
