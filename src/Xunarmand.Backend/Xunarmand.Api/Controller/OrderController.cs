using MediatR;
using Microsoft.AspNetCore.Mvc;
using Xunarmand.Application.Orders.Commands;
using Xunarmand.Application.Orders.Queryies;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Application.Products.Commands;
using Xunarmand.Infrastructure.Orders.CommandsHandler;
using Xunarmand.Infrastructure.Orders.QueryHandler;

namespace Xunarmand.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class OrderController(IMediator mediator, IOrderService service) : ControllerBase
{

    [HttpGet]
    public async ValueTask<IActionResult> Get() => Ok(await service.GetOrders());
   
    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderCreateCommand command,
                                                   CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> Update([FromBody] OrderUpdateCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }

    [HttpDelete("{orderid:guid}")]
    public async ValueTask<IActionResult> DeleteById([FromRoute] Guid clientId, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new DeleteOrderCommand() {OrderId= clientId}, cancellationToken);
        return result ? Ok() : BadRequest();
    }
    
}