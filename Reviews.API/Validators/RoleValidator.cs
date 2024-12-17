using FluentValidation;
using Reviews.API.DTO.RoleDtos;

namespace Reviews.API.Validators;

public class RoleValidator : AbstractValidator<CreateRoleDto>
{
    public RoleValidator()
    {
        RuleFor(x => x.ActorId).NotNull().NotEmpty();
        RuleFor(x => x.FilmId).NotNull().NotEmpty();
        RuleFor(x => x.Title).NotNull().NotEmpty();
    }
}
