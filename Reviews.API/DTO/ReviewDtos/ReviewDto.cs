using Reviews.API.DTO.FilmDtos;
using Reviews.API.DTO.UserDtos;
using Reviews.API.Enums;

namespace Reviews.API.DTO.ReviewDtos;

public class ReviewDto
{
    public Guid Id { get; set; }
    public int Mark { get; set; }
    public string Text { get; set; } = string.Empty;
    public ReviewType Type { get; set; }
    public Guid FilmId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public FilmDto? Film { get; set; }
    public UserDto? User { get; set; }
}
