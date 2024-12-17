namespace Reviews.API.Models;

public class Actor : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    public List<Role> Roles { get; set; } = new();
    public List<Film> Films { get; set; } = new();
}
