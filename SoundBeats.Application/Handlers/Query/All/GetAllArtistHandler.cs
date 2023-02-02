using MediatR;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Application.Handlers.Query.All
{
    public class GetAllArtistHandler : IRequestHandler<GetAllArtistQuery, IEnumerable<ArtistDTO>>
    {
        private readonly IArtistService _artistService;

        public GetAllArtistHandler(IArtistService artistService) => _artistService = artistService;

        public async Task<IEnumerable<ArtistDTO>> Handle(GetAllArtistQuery request, CancellationToken cancellationToken) =>
            await _artistService.GetArtists(cancellationToken);

    }
}
