using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ShipperQueries
{
    public class GetShipperQuery : IRequest<List<GetShipperQueryResult>>
    {
    }
}
