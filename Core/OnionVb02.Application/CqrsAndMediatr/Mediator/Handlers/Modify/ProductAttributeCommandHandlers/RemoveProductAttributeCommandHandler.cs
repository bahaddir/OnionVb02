using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeCommandHandlers
{
    public class RemoveProductAttributeCommandHandler : IRequestHandler<RemoveProductAttributeCommand>
    {
        private readonly IProductAttributeRepository _repository;

        public RemoveProductAttributeCommandHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductAttributeCommand request, CancellationToken cancellationToken)
        {
            ProductAttribute value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
