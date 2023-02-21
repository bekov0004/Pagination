using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.MapperProfiles;

public class InfrastructureProfile:Profile
{
    public InfrastructureProfile()
    {
        CreateMap<Movie,MoviesDto>().ReverseMap();
        CreateMap<Category,CategoryMovies>().ReverseMap();
    }
    
}