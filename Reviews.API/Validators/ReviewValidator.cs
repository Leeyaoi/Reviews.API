using FluentValidation;
using Reviews.API.DTO.ReviewDtos;

namespace Reviews.API.Validators;

public class ReviewValidator : AbstractValidator<CreateReviewDto>
{
    public ReviewValidator()
    {
        RuleFor(x => x.Mark).NotNull().LessThanOrEqualTo(0).GreaterThanOrEqualTo(5);
        RuleFor(x => x.Text).NotNull().NotEmpty();
        RuleFor(x => x.Type).NotNull();
        RuleFor(x => x.FilmId).NotNull().NotEmpty();
        RuleFor(x => x.UserId).NotNull().NotEmpty();
    }
}
