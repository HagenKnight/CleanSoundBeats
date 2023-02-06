using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class DeleteGenreDTO : CommandDTO, IRequest<ApiResponse<DeleteGenreDTO>>
    {
        public int Id { get; set; }
        public int? AccountIdDeleteDate { get; set; }
        public bool AutoSave { get; set; }
    }
}
