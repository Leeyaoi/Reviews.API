using Reviews.API.DTO.ReviewDtos;

namespace Reviews.API.DTO.UserDtos;

public class UserDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly RegistrationDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<ReviewDto> Reviews { get; set; } = new();
}
