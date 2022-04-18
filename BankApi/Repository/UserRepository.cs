﻿using BankApi.Interfaces;
using BankApi.Models;

namespace BankApi.Repository
{
    public class UserRepository : IUserRepository
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
    }
}
