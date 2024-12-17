using Reviews.API.DTO.FilmDtos;

namespace Reviews.API.DTO.DirectorDtos;

public class DirectorDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<FilmDto> Films { get; set; } = new();
}
