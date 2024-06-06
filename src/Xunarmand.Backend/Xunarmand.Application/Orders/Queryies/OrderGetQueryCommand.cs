using Xunarmand.Application.Orders.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Application.Orders.Queryies;

public class OrderGetQueryCommand:IQuery<ICollection<Order>>
{
    
}