using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ReadProductAttributeAttributeCommandHandlers
{
    public class GetProductAttributeByIdQueryHandler : IRequestHandler<GetProductAttributeByIdQuery, GetProductAttributeByIdQueryResult>
    {
        private readonly IProductAttributeRepository _repository;

        public GetProductAttributeByIdQueryHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductAttributeByIdQueryResult> Handle(GetProductAttributeByIdQuery request, CancellationToken cancellationToken)
        {
            ProductAttribute value = await _repository.GetByIdAsync(request.Id);
            return new GetProductAttributeByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }


}