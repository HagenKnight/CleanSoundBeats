using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class GenreDTOCreate : CommandDTO, IRequest<ApiResponse <GenreDTOCreate>>
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
