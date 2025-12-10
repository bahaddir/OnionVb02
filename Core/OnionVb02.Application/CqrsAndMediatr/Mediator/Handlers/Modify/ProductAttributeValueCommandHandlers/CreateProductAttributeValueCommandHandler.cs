using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeValueCommandHandlers
{
    public class CreateProductAttributeValueCommandHandler : IRequestHandler<CreateProductAttributeValueCommand>
    {
        private readonly IProductAttributeValueRepository _repository;

        public CreateProductAttributeValueCommandHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductAttributeValue
            {
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted,
                ProductAttributeId = request.ProductAttributeId,
                ProductId = request.ProductId,
                Value=request.Value
            });
        }
    }
}
