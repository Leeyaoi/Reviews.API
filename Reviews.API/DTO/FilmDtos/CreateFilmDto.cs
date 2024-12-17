namespace Reviews.API.DTO.FilmDtos;

public class CreateFilmDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public Guid DirectorId { get; set; }
}
