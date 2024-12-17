using Reviews.API.DTO.ActorDtos;
using Reviews.API.DTO.DirectorDtos;
using Reviews.API.DTO.ReviewDtos;
using Reviews.API.DTO.RoleDtos;

namespace Reviews.API.DTO.FilmDtos;

public class FilmDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public Guid DirectorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public DirectorDto? Director { get; set; }
    public List<RoleDto> Roles { get; set; } = new();
    public List<ReviewDto> Reviews { get; set; } = new();
    public List<ActorDto> Actors { get; set; } = new();
}
