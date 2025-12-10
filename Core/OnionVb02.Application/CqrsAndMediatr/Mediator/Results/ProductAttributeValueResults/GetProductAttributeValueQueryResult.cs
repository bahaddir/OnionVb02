using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults
{
    public class GetProductAttributeValueQueryResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string Value { get; set; }
    }
}
