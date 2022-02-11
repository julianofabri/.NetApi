using AutoMapper;
using BankApi.Dtos;
using BankApi.Models;

namespace BankApi.DtoMappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
