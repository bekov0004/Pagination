using AutoMapper;
using Domain.Dtos;
using Domain.Filter;
using Domain.Wrapper;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class MovieService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public MovieService(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PagedResponse<List<MoviesDto>>> GetMovies(FilterMovies filter)
    {
        var query = _context.Movies.AsQueryable();
        
        if (filter.MovieName != null)
            query = query.Where(x => x.Title.ToLower().Contains(filter.MovieName.ToLower()));
        
        if (filter.CategoryName != null)
            query = query.Where(x => x.Category.Title.ToLower().Contains(filter.CategoryName.ToLower()));
        
        var totalRecords = query.Count();
        var filtered = query.Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize).OrderBy(x=>x.Id).ToList();
        
        var mapped = _mapper.Map<List<MoviesDto>>(filtered);
        
        return new PagedResponse<List<MoviesDto>>(mapped, totalRecords, filter.PageNumber, filter.PageSize);
    }
    
    
    
    public async Task<PagedResponse<List<CategoryMovies>>> GetCategoryByList(FilterCategory filter)
    {
        var query = _context.Categories.AsQueryable();
        
        if (filter.CategoryName != null)
            query = query.Where(x => x.Title.ToLower().Contains(filter.CategoryName.ToLower()));

        query = (from c in query
            select new CategoryMovies()
            {
                CategoryName = c.Title,
                Movies = _context.Movies.Select(x => new MoviesDto()
                {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    MovieYear = x.MovieYear,
                    Title = x.Title
                })
            })
        
        var totalRecords = query.Count();
        var filtered = query.Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize).OrderBy(x=>x.Id).ToList();

        var mapped = _mapper.Map<List<CategoryMovies>>(filtered);
        
        return new PagedResponse<List<CategoryMovies>>(mapped, totalRecords, filter.PageNumber, filter.PageSize);
    }
    
    
    
}