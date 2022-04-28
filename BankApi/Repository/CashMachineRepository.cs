using BankApi.Interfaces;
using BankApi.Models;

namespace BankApi.Repository
{
    public class CashMachineRepository : ICashMachineRepository
    {
        readonly AppDbContext _context;

        public CashMachineRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Deposit(double value, BankAccount bankAccount)
        {
            bankAccount.Balance += value;
            _context.SaveChanges();
        }

        public BankAccount? GetByAgency(string agency)
        {
            var bankAccount = _context.BankAccounts.FirstOrDefault(a => a.Agency == agency);
            return bankAccount;
        }

        public void Withdraw(double value, BankAccount bankAccount)
        {
            bankAccount.Balance -= value;
            _context.SaveChanges();
        }
    }
}
