using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class CreateArtistDTO : CommandDTO, IRequest<ApiResponse<CreateArtistDTO>>
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public int CountryId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
