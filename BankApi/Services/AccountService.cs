using BankApi.Dtos;
using BankApi.Models;
using BankApi.Repository;

namespace BankApi.Services
{
    public class AccountService
    {
        readonly AccountRepository _accountRepository;
        readonly StatmentRepository _statmentRepository;

        public AccountService(AccountRepository accountRepository, StatmentRepository statmentRepository)
        {
            _accountRepository = accountRepository;
            _statmentRepository = statmentRepository;
        }

        public List<Account> GetAll()
        {
            var allAccounts = _accountRepository.GetAll();
            return allAccounts;
        }

        public void AddAccount(AccountDto accountDto)
        {
            _accountRepository.AddAccount(accountDto);
        }

        public void UpdateAccount(AccountDto accountDto, long id)
        {
            var account = _accountRepository.GetById(id);
            var statment = new StatmentDto()
            {
                AccountId = account.Id,
                Description = accountDto.Amount.ToString(),
                date = DateTime.UtcNow
            };

            _statmentRepository.AddStatment(statment);
            _accountRepository.UpdateAccount(accountDto, id);
        }

        public Account GetById(long id)
        {
            var account = _accountRepository.GetById(id);
            return account;
        }
    }
}
