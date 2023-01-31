using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class GenreDTOUpdate : CommandDTO, IRequest<ApiResponse<GenreDTOUpdate>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AccountIdUpdateDate { get; set; }
    }
}
