namespace Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string MovieYear { get; set; }
    public int CategoryId { get; set; }
    public  Category Category { get; set; }
    public List<Casts> Casts { get; set; }

    public Movie()
    {
        
    }
    
    public Movie(int id, string title, string movieYear, int categoryId)
    {
        Id = id;
        Title = title;
        MovieYear = movieYear;
        CategoryId = categoryId;
    }
}