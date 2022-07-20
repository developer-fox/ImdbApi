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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoriesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity = await _context.Categories.Include(x => x.Movies).ToListAsync();

            if (entity is null)
                return NotFound();

            var dto = _mapper.Map<List<CategoryListDto>>(entity);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {
            var entity = await _context.Categories.AddAsync(new Category { Name = categoryDto.Name });
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), entity);
        }
    }
}
