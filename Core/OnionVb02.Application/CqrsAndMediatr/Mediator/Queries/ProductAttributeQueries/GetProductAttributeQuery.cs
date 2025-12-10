using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries
{
    public class GetProductAttributeQuery : IRequest<List<GetProductAttributeQueryResult>>
    {
    }
}
