using BankApi.Interfaces;
using BankApi.Models;

namespace BankApi.Services
{
    public class UserService
    {
        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            var allUsers = _userRepository.GetAll();
            return allUsers;
        }
    }
}
