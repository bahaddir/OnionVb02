using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ShipperQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;
using OnionVb02.Domain.Entities;

namespace OnionVb02.WebApi.Controllers.MediatorControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShipperController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ShipperList()
        {
            List<GetShipperQueryResult> appUsers = await _mediator.Send(new GetShipperQuery());
            return Ok(appUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShipper(int id)
        {
            GetShipperByIdQueryResult value = await _mediator.Send(new GetShipperByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShipper(CreateShipperCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateShipper(UpdateShipperCommand command)
        {
            await _mediator.Send(command);
            return Ok("Veri güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShipper(int id)
        {
            await _mediator.Send(new RemoveShipperCommand(id));
            return Ok("Veri Silindi");
        }
    }
}
