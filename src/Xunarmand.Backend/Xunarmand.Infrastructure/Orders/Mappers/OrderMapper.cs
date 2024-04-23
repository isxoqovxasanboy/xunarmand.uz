using AutoMapper;
using Xunarmand.Application.Orders.Models;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Orders.Mappers;

public class OrderMapper:Profile
{
    public OrderMapper()
    {
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}