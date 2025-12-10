using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeValueCommandHandlers
{
    public class UpdateProductAttributeValueCommandHandler : IRequestHandler<UpdateProductAttributeValueCommand>
    {
        private readonly IProductAttributeValueRepository _repository;

        public UpdateProductAttributeValueCommandHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            ProductAttributeValue value = await _repository.GetByIdAsync(request.Id);
            value.ProductId = request.ProductId;
            value.ProductAttributeId = request.ProductAttributeId;
            value.Value = request.Value;
            value.Status = Domain.Enums.DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;
            await _repository.SaveChangesAsync();
        }
    }
}
