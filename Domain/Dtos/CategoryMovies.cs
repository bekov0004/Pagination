namespace Domain.Dtos;

public class CategoryMovies
{
    public string CategoryName { get; set; }
    public List<MoviesDto> Movies{ get; set; }
}