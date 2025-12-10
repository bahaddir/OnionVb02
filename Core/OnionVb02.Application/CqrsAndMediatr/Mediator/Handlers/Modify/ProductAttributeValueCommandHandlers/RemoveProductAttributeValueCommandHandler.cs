using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeValueCommandHandlers
{
    public class RemoveProductAttributeValueCommandHandler : IRequestHandler<RemoveProductAttributeValueCommand>
    {
        private readonly IProductAttributeValueRepository _repository;

        public RemoveProductAttributeValueCommandHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            ProductAttributeValue value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
