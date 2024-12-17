namespace Reviews.API.DTO.RoleDtos;

public class CreateRoleDto
{
    public Guid ActorId { get; set; }
    public Guid FilmId { get; set; }
    public string Title { get; set; } = string.Empty;
}
