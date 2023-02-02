using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Application.Handlers.Command
{
    public class DeleteGenreHandler : IRequestHandler<DeleteGenreDTO, ApiResponse<DeleteGenreDTO>>
    {
        private readonly IGenreService _genreService;

        public DeleteGenreHandler(IGenreService genreService) =>
            _genreService = genreService;

        public async Task<ApiResponse<DeleteGenreDTO>> Handle(DeleteGenreDTO request, CancellationToken cancellationToken)
        {
            var entity = await _genreService.DeleteGenre(request, request.AutoSave, cancellationToken);
            return new ApiResponse<DeleteGenreDTO>(entity, $"The Genre with ID {entity.Id} was deleted successfully.");
        }
    }
}
