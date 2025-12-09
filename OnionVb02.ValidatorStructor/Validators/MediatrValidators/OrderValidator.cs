using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommands;

namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class OrderValidator : AbstractValidator<CreateOrderCommand>
    {
        public OrderValidator()
        {
            RuleFor(x => x.ShippingAddress).NotEmpty().WithMessage("Ürün adı boş olamaz.");
        }
    }

}
