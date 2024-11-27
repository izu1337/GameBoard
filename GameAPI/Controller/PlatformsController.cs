using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameAPI.Data;
using GameAPI.Models;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly GameContext _context;

        public PlatformsController(GameContext context)
        {
            _context = context;
        }

        [HttpGet]
        // méthode GET qui permet de récupérer les données de la table 'Platforms'
        public async Task<ActionResult<IEnumerable<Platform>>> GetPlatforms()
        {
            return await _context.Platforms.ToListAsync();
        }
    }
}
