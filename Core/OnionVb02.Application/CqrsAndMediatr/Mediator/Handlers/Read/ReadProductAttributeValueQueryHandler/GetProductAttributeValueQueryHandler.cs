using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ReadProductAttributeValueCommandHandlers
{
    public class GetProductAttributeValueQueryHandler : IRequestHandler<GetProductAttributeValueQuery, List<GetProductAttributeValueQueryResult>>
    {
        private readonly IProductAttributeValueRepository _repository;

        public GetProductAttributeValueQueryHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductAttributeValueQueryResult>> Handle(GetProductAttributeValueQuery request, CancellationToken cancellationToken)
        {
            List<ProductAttributeValue> values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductAttributeValueQueryResult
            {
                Id = x.Id,
                ProductId = x.ProductId,
                ProductAttributeId = x.ProductAttributeId,
                Value = x.Value,
            }).ToList();
        }
    }

    


}