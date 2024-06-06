using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Orders.Commands;

public class DeleteOrderCommand:ICommand<bool>
{
    public Guid OrderId { get; set; }
}