using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeCommandHandlers
{
    public class CreateProductAttributeCommandHandler : IRequestHandler<CreateProductAttributeCommand>
    {
        private readonly IProductAttributeRepository _repository;

        public CreateProductAttributeCommandHandler(IProductAttributeRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductAttribute
            {
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted,
                Name = request.Name,
            });
        }
    }
}
