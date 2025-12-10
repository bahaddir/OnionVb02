using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ShipperCommandHandlers
{
    public class UpdateShipperCommandHandler : IRequestHandler<UpdateShipperCommand>
    {
        private readonly IShipperRepository _repository;

        public UpdateShipperCommandHandler(IShipperRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateShipperCommand request, CancellationToken cancellationToken)
        {
            Shipper value = await _repository.GetByIdAsync(request.Id);
            value.CompanyName = request.CompanyName;
            value.Phone = request.Phone;
            value.Status = Domain.Enums.DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;
            await _repository.SaveChangesAsync();
        }
    }
}
