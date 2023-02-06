using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class CreateGenreDTO : CommandDTO, IRequest<ApiResponse <CreateGenreDTO>>
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
