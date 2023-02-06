using MediatR;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Handlers.Query
{
    public class GetGenreHandler : IRequestHandler<GetGenreQuery, GenreDTO>
    {
        private readonly IGenreService _genreService;

        public GetGenreHandler(IGenreService genreService) => _genreService = genreService;

        public async Task<GenreDTO> Handle(GetGenreQuery request, CancellationToken cancellationToken) =>
            await _genreService.FindGenre(request.Id, cancellationToken);

    }
}
