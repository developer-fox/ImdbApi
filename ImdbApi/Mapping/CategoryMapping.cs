using AutoMapper;
using ImdbApi.Entities;
using ImdbApi.Models;

namespace ImdbApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CategoryListDto>().ReverseMap();
        }
    }
}
