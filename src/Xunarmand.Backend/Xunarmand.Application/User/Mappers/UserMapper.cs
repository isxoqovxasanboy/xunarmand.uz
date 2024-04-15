using AutoMapper;
using Xunarmand.Application.User.Models;

namespace Xunarmand.Application.User.Mappers;

public class UserMapper: Profile
{
    public UserMapper()
    {
        CreateMap<Domain.Entities.User, UserDto>().ReverseMap();
    }
}