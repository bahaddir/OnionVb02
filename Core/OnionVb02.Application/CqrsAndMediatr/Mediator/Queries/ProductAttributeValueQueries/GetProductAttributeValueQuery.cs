using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries
{
    public class GetProductAttributeValueQuery : IRequest<List<GetProductAttributeValueQueryResult>>
    {
    }
}
