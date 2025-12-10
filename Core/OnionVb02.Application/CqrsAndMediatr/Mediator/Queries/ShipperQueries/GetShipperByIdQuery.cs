using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ShipperQueries
{
    public class GetShipperByIdQuery : IRequest<GetShipperByIdQueryResult>
    {
        public int Id { get; set; }

        public GetShipperByIdQuery(int id)
        {
            Id = id;
        }
    }
}
