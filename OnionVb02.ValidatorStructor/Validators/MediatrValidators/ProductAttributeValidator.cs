using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class ProductAttributeValidator : AbstractValidator<CreateProductAttributeCommand>
    {
        public ProductAttributeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name boş olamaz.");
        }
    }

}
