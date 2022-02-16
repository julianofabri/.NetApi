using BankApi.Dtos;
using BankApi.Models;

namespace BankApi.Repository
{
    public class UserRepository
    {
        readonly AppDbContext _context;

        public UserRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<User> GetAll()
        {
            var result = _context.Users.ToList();
            return result;
        }

        public void AddUser(UserDto userDto)
        {
            var user = new User()
            {
                Name = userDto.Name,
            };
            
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetById(long id)
        {
           return _context.Users.FirstOrDefault(item => item.Id == id);
        }
    }
}
