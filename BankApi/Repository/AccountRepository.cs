using BankApi.Dtos;
using BankApi.Models;
using System.Diagnostics;

namespace BankApi.Repository
{
    public class AccountRepository
    {
        readonly AppDbContext _context;

        public AccountRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<Account> GetAll()
        {
            var result = _context.Accounts.ToList();
            return result;
        }

        public void AddAccount(AccountDto accountDto)
        {
            var account = new Account()
            {
                Amount = accountDto.Amount,
                UserId = accountDto.UserId,

            };
            try
            {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            } 
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void UpdateAccount(AccountDto accountDto, long id)
        {
            var account = _context.Accounts.FirstOrDefault(item => item.Id == id);

            if (account == null)
            {
                throw new Exception();
            }

            account.Amount = accountDto.Amount;
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public Account GetById(long id)
        {
            return _context.Accounts.FirstOrDefault(item => item.Id == id);
        }
    }
}
