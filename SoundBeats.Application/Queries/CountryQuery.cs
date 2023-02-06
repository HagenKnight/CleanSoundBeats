using MediatR;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Queries
{
    public class GetAllCountryQuery : IRequest<IEnumerable<CountryDTO>> { }

    public class GetCountryQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
        public GetCountryQuery(int id) => Id = id;
    }

}
