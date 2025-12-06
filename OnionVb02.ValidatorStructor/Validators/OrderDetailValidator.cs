using FluentValidation;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetailDto>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId boş olamaz.");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId boş olamaz.");
        }
    }

}
