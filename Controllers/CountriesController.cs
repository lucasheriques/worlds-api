using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Worlds.Controllers
{
    [Produces("application/json")]
    [Route("aplicacao/pais")]
    [EnableCors("MyPolicy")]
    public class CountriesController : Controller
    {
        private readonly worldContext _context;

        public CountriesController(worldContext context)
        {
            _context = context;
        }
        
        // GET: aplicacao/pais
        [HttpGet]
        public IEnumerable<Country> GetCountries()
        {
            return _context.Country;
        }
        
        // GET: api/Eventos
        [HttpGet("{id}/cidade")]
        public async Task<IActionResult> GetCitiesByCountry([FromRoute] string id)
        {
            var cidades = _context.City.Where(c => c.CountryCode == id);

            return Ok(cidades.ToList());
        }

    }
}