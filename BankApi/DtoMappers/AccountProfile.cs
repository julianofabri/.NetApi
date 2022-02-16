using AutoMapper;
using BankApi.Dtos;
using BankApi.Models;

namespace BankApi.DtoMappers
{
    public class StatmentProfile : Profile
    {
        public StatmentProfile()
        {
            CreateMap<Statment, StatmentDto>();
            CreateMap<StatmentDto, Statment>();
        }
    }
}
