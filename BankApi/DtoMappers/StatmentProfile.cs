using AutoMapper;
using BankApi.Dtos;
using BankApi.Models;

namespace BankApi.DtoMappers
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<AccountDto, Account>();
        }
    }
}
