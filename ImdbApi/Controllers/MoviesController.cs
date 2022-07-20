using AutoMapper;
using ImdbApi.Context;
using ImdbApi.Models;
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
        private readonly IMapper _mapper;

        public MoviesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _context.Movies.Include(x=>x.Categories).Include(x=>x.Genre).Where(x => x.Status == true).ToListAsync();

            if (movies is null)
                return NotFound();

            var dto = _mapper.Map<List<MovieDto>>(movies);

            return Ok(dto);
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetPopularMovies()
        {
            var popularMovies = await _context.Movies.Include(x=>x.Categories).Include(x => x.Genre).OrderByDescending(x => x.Like).Take(5).ToListAsync();
            
            if (popularMovies is null)
                return NotFound();

            var dto = _mapper.Map<List<MovieDto>>(popularMovies);

            return Ok(dto);
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetTopScoreMovies()
        {
            var topScoreMovies = await _context.Movies.Include(x => x.Categories).Include(x => x.Genre).OrderByDescending(x => x.Score).Take(5).ToListAsync();
            
            if (topScoreMovies is null)
                return NotFound();

            var dto = _mapper.Map<List<MovieDto>>(topScoreMovies);

            return Ok(dto);
        }

    }
}
