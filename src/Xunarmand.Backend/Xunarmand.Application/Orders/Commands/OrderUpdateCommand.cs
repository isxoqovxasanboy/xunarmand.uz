using System.Windows.Input;
using Xunarmand.Application.Orders.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Orders.Commands;

public class OrderUpdateCommand : ICommand<OrderDto>
{
    public OrderDto Order { get; set; }
}