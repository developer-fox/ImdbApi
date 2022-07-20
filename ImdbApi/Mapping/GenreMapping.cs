using AutoMapper;
using ImdbApi.Entities;
using ImdbApi.Models;

namespace ImdbApi.Mapping
{
    public class GenreMapping : Profile
    {
        public GenreMapping()
        {
            CreateMap<GenreDto, Genre>().ReverseMap();
            CreateMap<GenreForMovieListDto, Genre>().ReverseMap();
        }
    }
}
