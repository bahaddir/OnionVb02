using FluentValidation;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommands;
using OnionVb02.Application.DTOClasses;
namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class OrderDetailValidator : AbstractValidator<CreateOrderDetailCommand>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId boş olamaz.");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId boş olamaz.");
        }
    }

}
