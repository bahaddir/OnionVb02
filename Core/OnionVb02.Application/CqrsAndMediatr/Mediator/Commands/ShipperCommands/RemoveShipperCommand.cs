using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands
{
    public class RemoveShipperCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveShipperCommand(int id)
        {
            Id = id;
        }
    }
}
