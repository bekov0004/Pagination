namespace Domain.Entities;

public class Casts
{
    public int Id { get; set; }
    public int ActorId { get; set; }
    public Actor Actor { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public Casts()
    {
        
    }

    public Casts(int id, int actorId, int movieId)
    {
        Id = id;
        ActorId = actorId; 
        MovieId = movieId;
    }
}