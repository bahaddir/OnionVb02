using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommands;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators
{
    public class AppUserProfileValidator : AbstractValidator<CreateAppUserProfileCommand>
    {
        public AppUserProfileValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName boş olamaz.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName boş olamaz.");
        }
    }

}
