using MediatR;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Queries
{
    public class GetAllCountryQuery : IRequest<IEnumerable<GenreDTO>> { }

    public class GetCountryQuery : IRequest<GenreDTO>
    {
        public int Id { get; set; }
        public GetCountryQuery(int id) => Id = id;
    }

}
