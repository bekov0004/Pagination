using Domain.Entities;
using Infrastructure.Data;
using Microsoft.VisualBasic;

namespace Infrastructure.SeedData;

public  class SeedData
{
    public static void Seed(DataContext context)
    {
        if (context.Categories.Any()) return; 
        var category = new List<Category>()
        {
            new Category(1, "Action"),
            new Category(2, "Comedy"),
            new Category(3, "Fantasy"),
        };

        var movies = new List<Movie>()
        {
            new Movie(1, "Avengers: Endgame", "2019", 3),
            new Movie(2, "That's all he", "2021", 2),
            new Movie(3, "Infinity", "2021", 1)
        };

        var actor = new List<Actor>()
        {
            new Actor(1, "Robert Downey Jr.", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(2, "Chris Evans", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(3, "Chris Hemsworth", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(4, "Jeremy Renner", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(5, "Elizabeth Olsen", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(6, "Tom Holland", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(7, "Brie Larson", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
          
            new Actor(8, "Ray, Addison", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(9, "Tanner Buchanan", Gender.Man,DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(10, "Madison Pettis", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(11, "Isabella Crump", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(12, "Myra Molloy", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(13, "Vanessa Dubasso", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(14, "Dominic Goodman", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
         
            new Actor(15, "Mark Wahlberg", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(16, "Sophie Cookson", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(17, "Wallis Day", Gender.Woman, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(18, "Dylan O'Brien", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(19, "Jason Mantzoukas", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
            new Actor(20, "Joana Ribeiro", Gender.Man, DateTime.SpecifyKind(DateTime.Now.AddYears(1997),DateTimeKind.Utc)),
        };

        var casts = new List<Casts>()
        {
            new Casts(1, 1, 1),
            new Casts(2, 2, 1),
            new Casts(3, 3, 1),
            new Casts(4, 4, 1),
            new Casts(5, 5, 1),
            new Casts(6, 6, 1),
            new Casts(7, 7, 1),
            new Casts(8, 8, 2),
            new Casts(9, 9, 2),
            new Casts(10, 10, 2),
            new Casts(11, 11, 2),
            new Casts(12, 12, 2),
            new Casts(13, 13, 2),
            new Casts(14, 14, 2),
            new Casts(15, 15, 3),
            new Casts(16, 16, 3),
            new Casts(17, 17, 3),
            new Casts(18, 18, 3),
            new Casts(19, 19, 3),
            new Casts(20, 20, 3),
        };

        context.AddRange(category);
        context.AddRange(movies);
        context.AddRange(actor);
        context.AddRange(casts);
        context.SaveChanges();

    }
}