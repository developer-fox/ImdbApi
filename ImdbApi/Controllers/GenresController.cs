using AutoMapper;
using ImdbApi.Context;
using ImdbApi.Entities;
using ImdbApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImdbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GenresController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var genres = await _context.Genres.Include(x=>x.Movies).ToListAsync();
            
            if(genres is null)
                return NotFound();

            return Ok(genres);
        }
        [HttpPost]
        public async Task<IActionResult> Add(GenreDto genreDto)
        {
            var entity = await _context.Genres.AddAsync(new Genre { Id = genreDto.Id, Name = genreDto.Name });
            
            if (entity is null)
                return NotFound();

            var dto = _mapper.Map<GenreDto>(entity);

            return CreatedAtAction(nameof(Get), dto);
        }
    }
}
