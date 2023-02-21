namespace Domain.Filter;

public class FilterMovies:PaginationFilter
{
    public string MovieName { get; set; }
    public string CategoryName { get; set; }
}