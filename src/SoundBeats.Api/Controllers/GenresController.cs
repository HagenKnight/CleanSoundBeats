using MediatR;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GenresController(IMediator mediator) => _mediator = mediator;

        // GET: api/Genres
        [HttpGet]
        public async Task<IEnumerable<GenreDTO>> GetGenres() =>
            await _mediator.Send(new GetAllGenreQuery());


        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<GenreDTO> GetGenre(int id) =>
            await _mediator.Send(new GetGenreQuery(id));


        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ApiResponse<CreateGenreDTO>> Post(CreateGenreDTO command) =>
            await _mediator.Send(command);


        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ApiResponse<GenreDTOUpdate>> Put(GenreDTOUpdate command) =>
            await _mediator.Send(command);

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<ApiResponse<DeleteGenreDTO>> Delete(DeleteGenreDTO command) =>
            await _mediator.Send(command);

    }
}
