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
        //[HttpGet]
        /*public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            var _countries = await _countryRepository.GetCountries();
            return Ok(_countries);
        }*/

        /*public async Task<IEnumerable<CountryDTO>> GetCountries() =>
           await _mediator.Send(new GetAllCountryQuery());

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<CountryDTO> GetCountry(int id) =>
            await _mediator.Send(new GetCountryQuery(id));*/


        //// PUT: api/Countries/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCountry(int id, Country country)
        //{
        //    if (id != country.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(country).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CountryExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Countries
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Country>> PostCountry(Country country)
        //{
        //    if (_context.Countries == null)
        //    {
        //        return Problem("Entity set 'SoundBeatsDbContext.Countries'  is null.");
        //    }
        //    _context.Countries.Add(country);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        //}

        //// DELETE: api/Countries/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCountry(int id)
        //{
        //    if (_context.Countries == null)
        //    {
        //        return NotFound();
        //    }
        //    var country = await _context.Countries.FindAsync(id);
        //    if (country == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Countries.Remove(country);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CountryExists(int id)
        //{
        //    return (_context.Countries?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
