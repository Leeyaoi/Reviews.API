using Reviews.API.DTO.FilmDtos;
using Reviews.API.DTO.RoleDtos;

namespace Reviews.API.DTO.ActorDtos;

public class ActorDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<RoleDto> Roles { get; set; } = new();
    public List<FilmDto> Films { get; set; } = new();
}