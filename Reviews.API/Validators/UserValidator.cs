using FluentValidation;
using Reviews.API.DTO.UserDtos;

namespace Reviews.API.Validators;

public class UserValidator : AbstractValidator<CreateUserDto>
{
    public UserValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty();
        RuleFor(x => x.RegistrationDate).NotNull().NotEmpty();
    }
}
