using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ShipperCommandHandlers
{
    public class RemoveShipperCommandHandler : IRequestHandler<RemoveShipperCommand>
    {
        private readonly IShipperRepository _repository;

        public RemoveShipperCommandHandler(IShipperRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveShipperCommand request, CancellationToken cancellationToken)
        {
            Shipper value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
