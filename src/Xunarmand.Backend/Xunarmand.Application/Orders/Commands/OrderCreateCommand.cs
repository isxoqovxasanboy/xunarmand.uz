using Xunarmand.Application.Orders.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Orders.Commands;

public record OrderCreateCommand:ICommand<OrderDto> 
{
    public OrderDto Order { get; set; }
}