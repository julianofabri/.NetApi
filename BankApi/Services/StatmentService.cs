using BankApi.Dtos;
using BankApi.Models;
using BankApi.Repository;

namespace BankApi.Services
{
    public class StatmentService
    {
        readonly StatmentRepository _statmentRepository;

        public StatmentService(StatmentRepository statmentRepository)
        {
            _statmentRepository = statmentRepository;
        }

        public List<Statment> GetAll()
        {
            var allStatments = _statmentRepository.GetAll();
            return allStatments;
        }

        public void AddStatment(StatmentDto statmentDto)
        {
            _statmentRepository.AddStatment(statmentDto);
        }

        public void UpdateStatment(StatmentDto statmentDto, long id)
        {
            _statmentRepository.UpdateStatment(statmentDto, id);
        }

        public Statment GetById(long id)
        {
            var statment = _statmentRepository.GetById(id);
            return statment;
        }
    }
}
