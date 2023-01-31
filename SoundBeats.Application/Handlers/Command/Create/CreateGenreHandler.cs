using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Handlers.Command
{
    public class CreateGenreHandler : IRequestHandler<GenreDTOCreate, ApiResponse <GenreDTOCreate>>
    {
        private readonly IGenreService _genreService;

        public CreateGenreHandler(IGenreService genreService) =>
            _genreService = genreService;

        public async Task<ApiResponse<GenreDTOCreate>> Handle(GenreDTOCreate request, CancellationToken cancellationToken) 
        {
            var entity = await _genreService.AddGenre(request, cancellationToken);
            return new ApiResponse<GenreDTOCreate>(entity, $"The Genre with name {entity.Name} was created successfully.");
        }
    }
}
