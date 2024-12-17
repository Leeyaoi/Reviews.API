using FluentValidation;
using Reviews.API.DTO.DirectorDtos;

namespace Reviews.API.Validators;

public class DirectorValidator : AbstractValidator<CreateDirectorDto>
{
    public DirectorValidator()
    {
        RuleFor(a => a.Name).NotNull().NotEmpty();
        RuleFor(a => a.Surname).NotNull().NotEmpty();
        RuleFor(a => a.Country).NotNull().NotEmpty();
    }
}
