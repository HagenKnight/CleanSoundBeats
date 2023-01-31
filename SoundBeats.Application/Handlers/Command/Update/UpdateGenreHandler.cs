using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Handlers.Command
{
    public class UpdateGenreHandler : IRequestHandler<GenreDTOUpdate, ApiResponse<GenreDTOUpdate>>
    {
        private readonly IGenreService _genreService;

        public UpdateGenreHandler(IGenreService genreService) =>
            _genreService = genreService;

        public async Task<ApiResponse<GenreDTOUpdate>> Handle(GenreDTOUpdate request, CancellationToken cancellationToken)
        {
            var entity = await _genreService.UpdateGenre(request, cancellationToken);
            return new ApiResponse<GenreDTOUpdate>(entity, $"The Genre with name {entity.Name} was updated successfully.");
        }
    }
}
