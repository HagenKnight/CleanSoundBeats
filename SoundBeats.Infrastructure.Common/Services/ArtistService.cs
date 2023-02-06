using AutoMapper;
using SoundBeats.Core.DTO;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Exceptions;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services.Base;

namespace SoundBeats.Infrastructure.Common.Services
{
    public class ArtistService : CRUDService<ArtistDTO, CommandDTO, int,
                                Artist, IArtistRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                IArtistService
    {
        public ArtistService(IArtistRepository<SoundBeatsDbContext> repository,
            IUnitOfWork<SoundBeatsDbContext> unitOfWork,
            IMapper mapper) : base(repository,
                                   unitOfWork,
                                   mapper)
        {

        }

        public async Task<IEnumerable<ArtistDTO>> GetArtists(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<ArtistDTO> FindArtist(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<CreateArtistDTO> AddArtist(CreateArtistDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Name == objDTO.Name && u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), objDTO.Name);
            else
                return Mapper.Map<CreateArtistDTO>(await InsertAsync(objDTO, cancellationToken));
        }

        public async Task<UpdateArtistDTO> UpdateArtist(UpdateArtistDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.Name == objDTO.Name && u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Name);
            else
                return Mapper.Map<UpdateArtistDTO>(await UpdateAsync(objDTO, cancellationToken));
        }

        public async Task<DeleteArtistDTO> DeleteArtist(DeleteArtistDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteArtistDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }

    }
}
