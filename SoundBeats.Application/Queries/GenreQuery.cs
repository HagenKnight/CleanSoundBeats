using MediatR;
using SoundBeats.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Application.Queries
{
    public class GetAllGenreQuery : IRequest<IEnumerable<GenreDTO>> { }

    public class GetGenreQuery : IRequest<GenreDTO>
    {
        public int Id { get; set; }
        public GetGenreQuery(int id) => Id = id;
    }

}
