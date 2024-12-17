using FluentValidation;
using Reviews.API.DTO.FilmDtos;

namespace Reviews.API.Validators;

public class FilmValidator : AbstractValidator<CreateFilmDto>
{
    public FilmValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty();
        RuleFor(x => x.Description).NotNull().NotEmpty();
        RuleFor(x => x.Date).NotNull().NotEmpty();
        RuleFor(x => x.DirectorId).NotNull().NotEmpty();
    }
}
