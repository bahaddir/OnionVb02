using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands
{
    public class RemoveProductAttributeValueCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductAttributeValueCommand(int id)
        {
            Id = id;
        }
    }
}
