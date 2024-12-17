using Reviews.API.Enums;

namespace Reviews.API.Models;

public class Review : BaseModel
{
    public int Mark { get; set; }
    public string Text { get; set; } = string.Empty;
    public ReviewType Type { get; set; }
    public Guid FilmId { get; set; }
    public Guid UserId { get; set; }

    public Film? Film { get; set; }
    public User? User { get; set; }
}
