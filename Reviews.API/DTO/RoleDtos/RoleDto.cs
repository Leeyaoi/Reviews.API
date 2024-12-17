using Reviews.API.DTO.ActorDtos;
using Reviews.API.DTO.FilmDtos;

namespace Reviews.API.DTO.RoleDtos;

public class RoleDto
{
    public Guid ActorId { get; set; }
    public Guid FilmId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Title { get; set; } = string.Empty;

    public ActorDto? Actor { get; set; }
    public FilmDto? Film { get; set; }
}
