using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Xunarmand.Application.Product.Commands;
using Xunarmand.Application.Products.Queries;
using Xunarmand.Application.Users.Commands;

namespace Xunarmand.Api.Controller;
[ApiController]
[Route("api/[controller]")]
public class ProductController(IMediator mediator,IMapper mapper): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] ProductGetQuery productGetQuery,CancellationToken cancellationToken)
    {
        var result = await mediator.Send(productGetQuery,cancellationToken);
        return Ok(result);
    }
    [HttpGet("{clientId:guid}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid clientId, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new ProductGetByIdQuery(){ProductId = clientId}, cancellationToken);
        return result is not null ? Ok(result) : NoContent();
    }

    [HttpGet("by-name/{ProductName}")]
    public async Task<ActionResult<string>> CheckClientByName([FromRoute] string productName, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new CheckProductByNameQuery() { ProductName =  productName}, cancellationToken);

        return result;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand productCreateCommand,
                                                   CancellationToken cancellationToken)
    {
        var result = await mediator.Send(productCreateCommand, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> Update([FromBody] UpdateProductCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }

    [HttpDelete("{productid:guid}")]
    public async ValueTask<IActionResult> DeleteById([FromRoute] Guid clientId, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new DeleteProductByIdCommand() {ProductId= clientId}, cancellationToken);
        return result ? Ok() : BadRequest();
    }

}