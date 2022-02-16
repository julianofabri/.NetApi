using BankApi.Dtos;
using BankApi.Models;
using BankApi.Repository;

namespace BankApi.Services
{
    public class UserService
    {
        readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            var allUsers = _userRepository.GetAll();
            return allUsers;
        }

        public void AddUser(UserDto userDto)
        {
            _userRepository.AddUser(userDto);
        }

        public User GetById(long id)
        {
            var user = _userRepository.GetById(id);
            return user;
        }
    }
}
