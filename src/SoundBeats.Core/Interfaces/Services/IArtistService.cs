using SoundBeats.Core.DTO;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<ArtistDTO>> GetArtists(CancellationToken cancellationToken = default);

        Task<ArtistDTO> FindArtist(int id, CancellationToken cancellationToken = default);

        //Task<ArtistDTO> FilterArtist(Expression<Func<Artist, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CreateArtistDTO> AddArtist(CreateArtistDTO objDTO, CancellationToken cancellationToken = default);
        Task<UpdateArtistDTO> UpdateArtist(UpdateArtistDTO objDTO, CancellationToken cancellationToken = default);
        Task<DeleteArtistDTO> DeleteArtist(DeleteArtistDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);

    }
}
