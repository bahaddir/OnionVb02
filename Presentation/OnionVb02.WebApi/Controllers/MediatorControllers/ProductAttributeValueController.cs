using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;
using OnionVb02.Domain.Entities;

namespace OnionVb02.WebApi.Controllers.MediatorControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributeValueController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductAttributeValueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductAttributeValueList()
        {
            List<GetProductAttributeValueQueryResult> appUsers = await _mediator.Send(new GetProductAttributeValueQuery());
            return Ok(appUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAttributeValue(int id)
        {
            GetProductAttributeValueByIdQueryResult value = await _mediator.Send(new GetProductAttributeValueByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAttributeValue(CreateProductAttributeValueCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAttributeValue(UpdateProductAttributeValueCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductAttributeValue(int id)
        {
            await _mediator.Send(new RemoveProductAttributeValueCommand(id));
            return Ok("Veri Silindi");
        }
    }
}
