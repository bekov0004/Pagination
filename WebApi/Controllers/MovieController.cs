using Domain.Dtos;
using Domain.Filter;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("[controller]")]
public class MovieController:ControllerBase
{
    private readonly MovieService _movieService;

    public MovieController(MovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("GetCountries")]
    public async Task<PagedResponse<List<MoviesDto>>> GetCountries([FromQuery]FilterMovies filter)=>await _movieService.GetMovies(filter);

    
    [HttpGet("GetCategory")]
    public async Task<PagedResponse<List<CategoryMovies>>> GetCategory([FromQuery]FilterCategory filter)=>await _movieService.GetCategoryByList(filter);
    
    
}