using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Actor
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthYear { get; set; }
    public DateTime DeathYear { get; set; }
    public List<Casts> Casts { get; set; }


    public Actor()
    {
        
    }

    public Actor(int id, string fullName, Gender gender, DateTime birthYear)
    {
        Id = id;
        FullName = fullName;
        Gender = gender;
        BirthYear = birthYear;
    }


}

public enum Gender
{
    Man=1,
    Woman
    
}