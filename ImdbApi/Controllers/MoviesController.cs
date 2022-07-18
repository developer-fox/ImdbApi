using ImdbApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImdbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _context.Movies.Where(x=>x.Status == true).ToListAsync();

            if (movies is null)
                return NotFound();

            return Ok(movies);
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetPopularMovies()
        {
            var popularMovies =await _context.Movies.OrderByDescending(x => x.Like).Take(5).ToListAsync();

            return Ok(popularMovies);
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetTopScoreMovies()
        {
            var topScoreMovies = await _context.Movies.OrderByDescending(x=>x.Score).Take(5).ToListAsync();            

            return Ok(topScoreMovies);
        }

    }
}
