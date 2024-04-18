using AutoMapper;
using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Products.Mappers;

public class ProductMapper:Profile
{
    public ProductMapper()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product,ProductCredential>().ReverseMap();
    }
}