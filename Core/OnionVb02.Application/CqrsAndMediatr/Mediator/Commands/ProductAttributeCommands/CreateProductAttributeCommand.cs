using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands
{
    public class CreateProductAttributeCommand : IRequest
    {
        public string Name { get; set; }
    }
}
