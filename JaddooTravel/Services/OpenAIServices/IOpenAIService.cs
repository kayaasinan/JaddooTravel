namespace JaddooTravel.Services.OpenAIServices
{
    public interface IOpenAIService
    {
        Task<string> GetPlacesAsync(string city, string country);
    }
}
