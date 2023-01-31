using AutoMapper;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.DTO.Genre;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Exceptions;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services.Base;

namespace SoundBeats.Infrastructure.Persistence.Services
{
    public class GenreService : CRUDService<GenreDTO, CommandDTO, int,
                                Genre, IGenreRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                IGenreService
    {
        public GenreService(IGenreRepository<SoundBeatsDbContext> repository,
            IUnitOfWork<SoundBeatsDbContext> unitOfWork,
            IMapper mapper) : base(repository,
                                   unitOfWork,
                                   mapper)
        {
        }

        public async Task<IEnumerable<GenreDTO>> GetGenres(CancellationToken cancellationToken = default) =>
            await GetAll(cancellationToken);


        public async Task<GenreDTO> FindGenre(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<GenreDTOCreate> AddGenre(GenreDTOCreate objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Name == objDTO.Name && u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), objDTO.Name);
            else
                return Mapper.Map<GenreDTOCreate>(await InsertAsync(objDTO, cancellationToken));
        }

        public async Task<GenreDTOUpdate> UpdateGenre(GenreDTOUpdate objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.Name == objDTO.Name && u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Name);
            else
                return Mapper.Map<GenreDTOUpdate>(await UpdateAsync(objDTO, cancellationToken));
        }


        public async Task<GenreDTODelete> DeleteGenre(GenreDTODelete objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() > 0)
                throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<GenreDTODelete>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }

    }
}
