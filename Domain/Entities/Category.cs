namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }

    public Category()
    {
        
    }

    public Category(int id, string title)
    {
        Id = id;
        Title = title;
    }
}