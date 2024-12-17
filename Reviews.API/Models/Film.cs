namespace Reviews.API.Models;

public class Film : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public Guid DirectorId { get; set; }

    public Director? Director { get; set; }
    public List<Role> Roles { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
    public List<Actor> Actors { get; set; } = new();
}
