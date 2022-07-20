using AutoMapper;
using ImdbApi.Entities;
using ImdbApi.Models;

namespace ImdbApi.Mapping
{
    public class MovieMapping : Profile
    {
        public MovieMapping()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieListDto>().ReverseMap();
        }
    }
}
