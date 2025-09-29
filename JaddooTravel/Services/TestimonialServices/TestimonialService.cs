using AutoMapper;
using JaddooTravel.Dtos.TestimonialDtos;
using JaddooTravel.Entities;
using JaddooTravel.Settings;
using MongoDB.Driver;

namespace JaddooTravel.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonialCollection;
        private readonly IMapper _mapper;

        public TestimonialService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Testimonial>(databaseSettings.TestimonialCollectionName);
            _mapper = mapper;
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            var testimonials = await _testimonialCollection.Find(t => true).ToListAsync();
            return _mapper.Map<List<ResultTestimonialDto>>(testimonials);
        }

        public async Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string id)
        {
            var testimonial = await _testimonialCollection.Find(t => t.TestimonialId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetTestimonialByIdDto>(testimonial);
        }

        public async Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            await _testimonialCollection.InsertOneAsync(testimonial);
        }

        public async Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            var updated = _mapper.Map<Testimonial>(updateTestimonialDto);
            await _testimonialCollection.FindOneAndReplaceAsync(t => t.TestimonialId == updateTestimonialDto.TestimonialId, updated);
        }

        public async Task DeleteTestimonialAsync(string id)
        {
            await _testimonialCollection.DeleteOneAsync(t => t.TestimonialId == id);
        }
    }
}