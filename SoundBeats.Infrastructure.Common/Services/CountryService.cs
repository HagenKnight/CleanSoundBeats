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
using SoundBeats.Core.Interfaces.Management;
using System.Linq.Expressions;
using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Infrastructure.Common.Services
{
    public class CountryService : CRUDService<CountryDTO, CommandDTO, int,
                                  Country, ICountryRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                  ICountryService
    {
        private readonly IDataShapeHelper<CountryDTO> _dataShaperHelper;

        public CountryService(ICountryRepository<SoundBeatsDbContext> repository,
            IUnitOfWork<SoundBeatsDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<CountryDTO> dataShapeHelper
            ) : base(repository,
                                   unitOfWork,
                                   mapper)
        {
            _dataShaperHelper = dataShapeHelper;
        }

        public async Task<IEnumerable<ShapedEntityDTO>> GetCountries(CancellationToken cancellationToken = default, string fields = null, string orderBy = null) =>
            await _dataShaperHelper.ShapeDataAsync(await GetAllAsync(cancellationToken, fields, orderBy), fields);


        public async Task<IEnumerable<ShapedEntityDTO>> GetPagedCountries(int pageNumber, int pageSize, CancellationToken cancellationToken = default, Expression<Func<Country, bool>> predicate = null, string fields = null, string orderBy = null) =>
            (predicate == null) ? await _dataShaperHelper.ShapeDataAsync(await GetPagedAsync(pageNumber, pageSize, cancellationToken, fields, orderBy), fields) :
                        await _dataShaperHelper.ShapeDataAsync(await GetPagedAsync(pageNumber, pageSize, predicate, cancellationToken, fields, orderBy), fields);


        public async Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);
    }
}
