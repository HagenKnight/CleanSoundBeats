using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenresController(IMapper mapper, IGenreRepository genreRepository)
        {
            _mapper = mapper;
            _genreRepository = genreRepository;
        }
        // GET: api/Genres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            var _genres = await _genreRepository.GetGenres();
            var _genresDTO = _mapper.Map<IEnumerable<GenreDTO>>(_genres);
            if (_genresDTO == null)
            {
                return NotFound();
            }
            return Ok(_genresDTO);
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
            try
            {
                var _genre = await _genreRepository.GetGenre(id);
                var _genreDTO = _mapper.Map<GenreDTO>(_genre);
                if (_genreDTO == null)
                {
                    return NotFound();
                }
                return Ok(_genreDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            var _genre = await _genreRepository.UpdateGenre(genre);
            return Ok(_genre);
        }

        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(GenreDTO genreDTO)
        {
            var _genre = _mapper.Map<Genre>(genreDTO);
            // insert date
            _genre.CreationDate = DateTime.Now;
            await _genreRepository.AddGenre(_genre);
            return Ok(genreDTO);
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            var _genre = await _genreRepository.DeleteGenre(id);

            if (_genre == null)
            {
                return NotFound();
            }
            return Ok(_genre);
        }
    }
}
