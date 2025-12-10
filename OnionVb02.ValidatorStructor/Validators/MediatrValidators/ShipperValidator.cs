using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class ShipperValidator : AbstractValidator<CreateShipperCommand>
    {
        public ShipperValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("CompanyName boş olamaz.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone boş olamaz.");
            RuleFor(x => x.Phone).Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Geçersiz telefon numarası formatı.");
        }
    }

}
