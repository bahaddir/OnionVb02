using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommands;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class AppUserValidator : AbstractValidator<CreateAppUserCommand>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName boş olamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password boş olamaz.");
        }
    }

}
