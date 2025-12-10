using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults
{
    public class GetShipperQueryResult
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
