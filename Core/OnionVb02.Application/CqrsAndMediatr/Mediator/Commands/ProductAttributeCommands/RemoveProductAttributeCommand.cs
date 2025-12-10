using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands
{
    public class RemoveProductAttributeCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductAttributeCommand(int id)
        {
            Id = id;
        }
    }
}
