using MediatR;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Queries
{
    public class GetAllGenreQuery : IRequest<IEnumerable<GenreDTO>> { }

    public class GetGenreQuery : IRequest<GenreDTO>
    {
        public int Id { get; set; }
        public GetGenreQuery(int id) => Id = id;
    }

}
