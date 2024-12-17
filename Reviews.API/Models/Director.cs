namespace Reviews.API.Models;

public class Director : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    public List<Film> Films { get; set; } = new();
}
