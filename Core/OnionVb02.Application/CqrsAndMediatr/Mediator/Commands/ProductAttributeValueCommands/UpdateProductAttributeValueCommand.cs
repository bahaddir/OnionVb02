using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands
{
    public class UpdateProductAttributeValueCommand : IRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string Value { get; set; }

    }
}
