using JaddooTravel.Dtos.TestimonialDtos;

namespace JaddooTravel.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialnDto);
        Task DeleteTestimonialAsync(string id);
        Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string id);
    }
}
