using MediatR;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Queries;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CountriesController(IMediator mediator) => _mediator = mediator;

        // GET: api/Countries
        [HttpGet]
        public async Task<IEnumerable<CountryDTO>> GetCountries() =>
           await _mediator.Send(new GetAllCountryQuery());

        
        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<CountryDTO> GetCountry(int id) =>
            await _mediator.Send(new GetCountryQuery(id));
        
    }
}
