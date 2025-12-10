using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries
{
    public class GetProductAttributeByIdQuery : IRequest<GetProductAttributeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductAttributeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
