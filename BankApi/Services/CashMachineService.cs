using BankApi.Interfaces;

namespace BankApi.Services
{
    public class CashMachineService
    {
        readonly ICashMachineRepository _cashMachineRepository;

        public CashMachineService(ICashMachineRepository cashMachineRepository)
        {
            _cashMachineRepository = cashMachineRepository;
        }

        public void Deposit(double value, string agency)
        {
            var bankAccount = _cashMachineRepository.GetByAgency(agency);
            _cashMachineRepository.Deposit(value, bankAccount);
        }

        public void Withdraw(double value, string agency)
        {
            var bankAccount = _cashMachineRepository.GetByAgency(agency);
            if(bankAccount == null)
            {
                throw new ArgumentException("Account not found");
            }
            _cashMachineRepository.Withdraw(value, bankAccount);
        }
    }
}
