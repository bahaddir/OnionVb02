using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands
{
    public class UpdateProductAttributeCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
