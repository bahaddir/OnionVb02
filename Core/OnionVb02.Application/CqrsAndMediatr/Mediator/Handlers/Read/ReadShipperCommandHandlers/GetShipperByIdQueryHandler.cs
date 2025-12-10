using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ShipperQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ReadShipperCommandHandlers
{
    public class GetShipperByIdQueryHandler : IRequestHandler<GetShipperByIdQuery, GetShipperByIdQueryResult>
    {
        private readonly IShipperRepository _repository;

        public GetShipperByIdQueryHandler(IShipperRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetShipperByIdQueryResult> Handle(GetShipperByIdQuery request, CancellationToken cancellationToken)
        {
            Shipper value = await _repository.GetByIdAsync(request.Id);
            return new GetShipperByIdQueryResult
            {
                Id = value.Id,
                CompanyName = value.CompanyName,
                Phone = value.Phone
            };
        }
    }
}
