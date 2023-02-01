using AutoMapper;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Exceptions;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services.Base;
using System.Collections;

namespace SoundBeats.Infrastructure.Common.Services
{
    public class CountryService : CRUDService<CountryDTO, CommandDTO, int,
                                  Country, ICountryRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                  ICountryService
    {
        public CountryService(ICountryRepository<SoundBeatsDbContext> repository,
            IUnitOfWork<SoundBeatsDbContext> unitOfWork,
            IMapper mapper) : base(repository,
                                   unitOfWork,
                                   mapper)
        {
        }

        public async Task<IEnumerable<CountryDTO>> GetCountries(CancellationToken cancellationToken = default) =>
            await GetAll(cancellationToken);


        public async Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

    }
}
