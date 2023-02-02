using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class UpdateArtistDTO : CommandDTO, IRequest<ApiResponse<UpdateArtistDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public int CountryId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
