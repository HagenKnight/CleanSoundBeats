using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Application.Handlers.Command.Delete
{
    public class DeleteArtistHandler : IRequestHandler<DeleteArtistDTO, ApiResponse<DeleteArtistDTO>>
    {
        private readonly IArtistService _artistService;

        public DeleteArtistHandler(IArtistService artistService) => 
            _artistService = artistService;

        public async Task<ApiResponse <DeleteArtistDTO>> Handle(DeleteArtistDTO request, CancellationToken cancellationToken)
        {
            var entity = await _artistService.DeleteArtist(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteArtistDTO>(entity, $"The Genre with ID {entity.Id} was deleted successfully.");
        }
    }
}
