using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands
{
    public class CreateShipperCommand:IRequest
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
