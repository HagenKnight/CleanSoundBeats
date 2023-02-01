using MediatR;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Handlers.Query.All
{
    public class GetAllCountryHandler : IRequestHandler<GetAllCountryQuery, IEnumerable<CountryDTO>>
    {
        private readonly ICountryService _countryService;

        public GetAllCountryHandler(ICountryService countryService) => _countryService = countryService;

        public async Task<IEnumerable<CountryDTO>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken) =>
            await _countryService.GetCountries(cancellationToken);

    }
}
