using FluentValidation;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators
{
    public class AppUserValidator : AbstractValidator<AppUserDto>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName boş olamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password boş olamaz.");
        }
    }

}
