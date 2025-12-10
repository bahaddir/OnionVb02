using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderCommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IOrderRepository _repository;

        public CreateOrderCommandHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Order
            {
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted,
                ShippingAddress = request.ShippingAddress,
                AppUserId = request.AppUserId,
                ShipperId = request.ShipperId
            });
        }
    }
}
