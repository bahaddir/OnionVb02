using FluentValidation;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators
{
    public class AppUserProfileValidator : AbstractValidator<AppUserProfileDto>
    {
        public AppUserProfileValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName boş olamaz.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName boş olamaz.");
        }
    }

}
