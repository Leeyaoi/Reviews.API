namespace Reviews.API.DTO.UserDtos;

public class CreateUserDto
{
    public string Name { get; set; } = string.Empty;
    public DateOnly RegistrationDate { get; set; }
}
