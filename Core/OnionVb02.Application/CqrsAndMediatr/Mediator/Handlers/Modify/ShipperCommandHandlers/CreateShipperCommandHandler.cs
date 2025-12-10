using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ShipperCommandHandlers
{
    public class CreateShipperCommandHandler : IRequestHandler<CreateShipperCommand>
    {
        private readonly IShipperRepository _repository;

        public CreateShipperCommandHandler(IShipperRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateShipperCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Shipper
            {
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted,
                CompanyName = request.CompanyName,
                Phone = request.Phone
            });
        }
    }
}
