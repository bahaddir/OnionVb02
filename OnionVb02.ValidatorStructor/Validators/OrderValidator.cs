using FluentValidation;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators
{
    public class OrderValidator : AbstractValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(x => x.ShippingAddress).NotEmpty().WithMessage("Ürün adı boş olamaz.");
        }
    }

}
