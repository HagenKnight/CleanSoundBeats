using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class DeleteArtistDTO : CommandDTO, IRequest<ApiResponse<DeleteArtistDTO>>
    {
        public int Id { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool AutoSave { get; set; }
    }
}
