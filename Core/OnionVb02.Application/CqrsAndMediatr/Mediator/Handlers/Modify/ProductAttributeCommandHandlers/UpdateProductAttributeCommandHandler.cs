using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeCommandHandlers
{
    public class UpdateProductAttributeCommandHandler : IRequestHandler<UpdateProductAttributeCommand>
    {
        private readonly IProductAttributeRepository _repository;

        public UpdateProductAttributeCommandHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            ProductAttribute value = await _repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            value.Status = Domain.Enums.DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;
            await _repository.SaveChangesAsync();
        }
    }
}
