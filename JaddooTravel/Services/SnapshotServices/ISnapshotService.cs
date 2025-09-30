using JaddooTravel.Dtos.SnapshotsDtos;

namespace JaddooTravel.Services.SnapshotServices
{
    public interface ISnapshotService
    {
        Task<GraficDestinationDto> GetGraficDataAsync();
    }
}
