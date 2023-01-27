using Microsoft.AspNetCore.Mvc;
using SoundBeats.Core.DTO.Genre;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            //_mapper = mapper;
            _genreService = genreService;
        }
        // GET: api/Genres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            var response = new ApiResponse<IEnumerable<GenreDTO>>(await _genreService.GetGenres());
            return Ok(response);
        }

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
        }
    }
}
