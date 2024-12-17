namespace Reviews.API.Models;

public class Role : BaseModel
{
    public Guid ActorId { get; set; }
    public Guid FilmId { get; set; }
    public string Title { get; set; } = string.Empty;

    public Actor? Actor { get; set; }
    public Film? Film { get; set; }
}
