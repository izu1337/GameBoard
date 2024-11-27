using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameAPI.Data;
using GameAPI.Models;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameContext _context;

        public GamesController(GameContext context)
        {
            _context = context;
        }

     [HttpGet]
     // Récupération des jeux (GetGames)
    public async Task<ActionResult<IEnumerable<GameDto>>> GetGames()
    {
        var games = await _context.Games
            .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
            .Select(game => new GameDto
            {
                Id = game.Id,
                Name = game.Name,
                Editor = game.Editor,
                StarRating = new GameDto.StarRatingDto
                {
                    Rate = game.Rate,
                    NbRates = game.NbRates
                },
                Platforms = game.GamePlatforms.Select(gp => gp.Platform.Name).ToList()
            })
            .ToListAsync();

        return games;
        }
    }
}

