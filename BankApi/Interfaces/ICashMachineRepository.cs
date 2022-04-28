using BankApi.Models;

namespace BankApi.Interfaces
{
    public interface ICashMachineRepository
    {
        void Deposit(double value, BankAccount bankAccount);
        BankAccount? GetByAgency(string agency);
        void Withdraw(double value, BankAccount bankAccount);
    }
}