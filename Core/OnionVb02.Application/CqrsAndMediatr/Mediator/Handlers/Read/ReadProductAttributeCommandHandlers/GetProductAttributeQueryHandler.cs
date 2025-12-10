using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ReadProductAttributeCommandHandlers
{
    public class GetProductAttributeQueryHandler : IRequestHandler<GetProductAttributeQuery, List<GetProductAttributeQueryResult>>
    {
        private readonly IProductAttributeRepository _repository;

        public GetProductAttributeQueryHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductAttributeQueryResult>> Handle(GetProductAttributeQuery request, CancellationToken cancellationToken)
        {
            List<ProductAttribute> values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductAttributeQueryResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }




}