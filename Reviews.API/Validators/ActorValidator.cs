using FluentValidation;
using Reviews.API.DTO.ActorDtos;

namespace Reviews.API.Validators;

public class ActorValidator : AbstractValidator<CreateActorDto>
{
    public ActorValidator()
    {
        RuleFor(a => a.Name).NotNull().NotEmpty();
        RuleFor(a => a.Surname).NotNull().NotEmpty();
        RuleFor(a => a.Country).NotNull().NotEmpty();
    }
}
