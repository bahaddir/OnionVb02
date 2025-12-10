using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using OnionVb02.Domain.Entities;

namespace OnionVb02.WebApi.Controllers.MediatorControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductAttributeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductAttributeList()
        {
            List<GetProductAttributeQueryResult> appUsers = await _mediator.Send(new GetProductAttributeQuery());
            return Ok(appUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAttribute(int id)
        {
            GetProductAttributeByIdQueryResult value = await _mediator.Send(new GetProductAttributeByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAttribute(CreateProductAttributeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAttribute(UpdateProductAttributeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductAttribute(int id)
        {
            await _mediator.Send(new RemoveProductAttributeCommand(id));
            return Ok("Veri Silindi");
        }
    }
}
