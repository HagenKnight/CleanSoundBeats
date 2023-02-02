using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArtistController(IMediator mediator) => _mediator = mediator;


        // GET: api/Artist
        [HttpGet]
        public async Task<IEnumerable<ArtistDTO>> GetArtists() =>
            await _mediator.Send(new GetAllArtistQuery());

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<ArtistDTO> GetArtist(int id) =>
            await _mediator.Send(new GetArtistQuery(id));

        // POST: api/Artist
        [HttpPost]
        public async Task<ApiResponse<CreateArtistDTO>> Post(CreateArtistDTO command) =>
            await _mediator.Send(command);

        // PUT: api/Artist/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ApiResponse<UpdateArtistDTO>> Put(UpdateArtistDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<ApiResponse<DeleteArtistDTO>> Delete(DeleteArtistDTO command) =>
            await _mediator.Send(command);
    }
}
