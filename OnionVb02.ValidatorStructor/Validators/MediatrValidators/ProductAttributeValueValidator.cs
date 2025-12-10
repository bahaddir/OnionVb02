using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class ProductAttributeValueValidator : AbstractValidator<CreateProductAttributeValueCommand>
    {
        public ProductAttributeValueValidator()
        {
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value boş olamaz.");
            RuleFor(x => x.ProductAttributeId).GreaterThan(0).WithMessage("Geçersiz ProductAttributeId.");
            RuleFor(x => x.ProductId).GreaterThan(0).WithMessage("Geçersiz ProductId.");    
        }
    }

}
