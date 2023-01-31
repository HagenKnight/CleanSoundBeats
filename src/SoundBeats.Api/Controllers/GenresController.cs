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
        public async Task<ApiResponse<GenreDTOCreate>> Post(GenreDTOCreate command) =>
            await _mediator.Send(command);


        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ApiResponse<GenreDTOUpdate>> Put(GenreDTOUpdate command) =>
            await _mediator.Send(command);

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<ApiResponse<GenreDTODelete>> Delete(GenreDTODelete command) =>
            await _mediator.Send(command);


        /*
        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
            GenreDTO _articleDTO = await _genreService.FindGenre(id);

            if (_articleDTO == null)
                return NotFound();

            var response = new ApiResponse<GenreDTO>(_articleDTO);
            return Ok(response);

        }

        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(GenreDTOUpdate obj)
        {
            obj = await _genreService.UpdateGenre(obj);
            var response = new ApiResponse<GenreDTOUpdate>(obj);
            return Ok(response);
        }

        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(GenreDTOCreate obj)
        {
            obj = await _genreService.AddGenre(obj);
            var response = new ApiResponse<GenreDTOCreate>(obj);
            return Ok(response);
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(GenreDTODelete obj)
        {
            obj = await _genreService.DeleteGenre(obj);
            var response = new ApiResponse<GenreDTODelete>(obj);
            return Ok(response);
        }*/
    }
}
