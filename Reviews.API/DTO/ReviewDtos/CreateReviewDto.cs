using Reviews.API.Enums;

namespace Reviews.API.DTO.ReviewDtos;

public class CreateReviewDto
{
    public int Mark { get; set; }
    public string Text { get; set; } = string.Empty;
    public ReviewType Type { get; set; }
    public Guid FilmId { get; set; }
    public Guid UserId { get; set; }
}
