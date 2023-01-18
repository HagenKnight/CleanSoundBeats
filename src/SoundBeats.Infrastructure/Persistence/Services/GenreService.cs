using AutoMapper;
using SoundBeats.Core.DTO.Genre;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Data;
using SoundBeats.Infrastructure.Persistence.Services.Base;

namespace SoundBeats.Infrastructure.Persistence.Services
{
    public class GenreService : CRUDService<GenreDTO, GenreDTOCreate, GenreDTOUpdate, GenreDTODelete, int, Genre, IGenreRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                IGenreService
    {
        public GenreService(IGenreRepository<SoundBeatsDbContext> repository, 
            IUnitOfWork<SoundBeatsDbContext> unitOfWork, 
            IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GenreDTO>> GetGenres(CancellationToken cancellationToken = default) => 
            await GetAll(cancellationToken);


        public async Task<GenreDTO> FindGenre(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<GenreDTOCreate> AddGenre(GenreDTOCreate objDTO, CancellationToken cancellationToken = default) =>
            await InsertAsync(objDTO, cancellationToken);

        public async Task<GenreDTOUpdate> UpdateGenre(GenreDTOUpdate objDTO, CancellationToken cancellationToken = default) =>
            await UpdateAsync(objDTO, cancellationToken);


        public async Task<GenreDTODelete> DeleteGenre(GenreDTODelete objDTO, bool autoSave = true, CancellationToken cancellationToken = default) =>
            await DeleteAsync(objDTO, autoSave, cancellationToken);

    }
}
