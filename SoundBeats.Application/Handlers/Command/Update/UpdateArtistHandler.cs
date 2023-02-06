using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Handlers.Command.Update
{
    public class UpdateArtistHandler : IRequestHandler<UpdateArtistDTO, ApiResponse<UpdateArtistDTO>>
    {
        private readonly IArtistService _artistService;
        public UpdateArtistHandler(IArtistService artistService) =>
            _artistService = artistService;

        public async Task<ApiResponse<UpdateArtistDTO>> Handle(UpdateArtistDTO request, CancellationToken cancellationToken)
        {
            var entity = await _artistService.UpdateArtist(request, cancellationToken);
            return new ApiResponse<UpdateArtistDTO>(entity, $"The Artist with name {entity.Name} was updated successfully.");
        }
    }
}
