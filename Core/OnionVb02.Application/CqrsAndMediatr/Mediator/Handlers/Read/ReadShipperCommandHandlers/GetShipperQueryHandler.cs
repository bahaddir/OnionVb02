using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ShipperQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ReadShipperCommandHandlers
{
    public class GetShipperQueryHandler : IRequestHandler<GetShipperQuery, List<GetShipperQueryResult>>
    {
        private readonly IShipperRepository _repository;

        public GetShipperQueryHandler(IShipperRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetShipperQueryResult>> Handle(GetShipperQuery request, CancellationToken cancellationToken)
        {
            List<Shipper> values = await _repository.GetAllAsync();
            return values.Select(x => new GetShipperQueryResult
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                Phone = x.Phone
            }).ToList();
        }
    }

    
}
