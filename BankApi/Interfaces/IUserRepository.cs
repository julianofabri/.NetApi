using BankApi.Models;

namespace BankApi.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}