namespace Reviews.API.Models;

public class User : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public DateOnly RegistrationDate { get; set; }

    public List<Review> Reviews { get; set; } = new();
}
