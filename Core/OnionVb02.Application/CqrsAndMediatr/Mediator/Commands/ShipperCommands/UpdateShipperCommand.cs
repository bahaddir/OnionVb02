using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands
{
    public class UpdateShipperCommand : IRequest
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
