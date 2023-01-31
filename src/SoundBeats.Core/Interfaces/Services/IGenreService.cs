using SoundBeats.Core.DTO;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDTO>> GetGenres(CancellationToken cancellationToken = default);

        Task<GenreDTO> FindGenre(int id, CancellationToken cancellationToken = default);

        //Task<GenreDTO> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default);
        Task<GenreDTOCreate> AddGenre(GenreDTOCreate objDTO, CancellationToken cancellationToken = default);
        Task<GenreDTOUpdate> UpdateGenre(GenreDTOUpdate objDTO, CancellationToken cancellationToken = default);
        Task<GenreDTODelete> DeleteGenre(GenreDTODelete objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
