using MediatR;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Handlers.Query.Single
{
    public class GetArtistHandler : IRequestHandler<GetArtistQuery, ArtistDTO>
    {
        public readonly IArtistService _artistService;
        public GetArtistHandler(IArtistService artistService) => _artistService = artistService;

        public async Task<ArtistDTO> Handle(GetArtistQuery request, CancellationToken cancellationToken) =>
            await _artistService.FindArtist(request.Id, cancellationToken);

    }
}
