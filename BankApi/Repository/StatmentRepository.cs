using BankApi.Dtos;
using BankApi.Models;

namespace BankApi.Repository
{
    public class StatmentRepository
    {
        readonly AppDbContext _context;

        public StatmentRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<Statment> GetAll()
        {
            var result = _context.Statments.ToList();
            return result;
        }

        public void AddStatment(StatmentDto statmentDto)
        {
            var statment = new Statment()
            {
                Description = statmentDto.Description,
                AccountId = statmentDto.AccountId,
                date = statmentDto.date,

            };

            _context.Statments.Add(statment);
            _context.SaveChanges();
        }

        public void UpdateStatment(StatmentDto statmentDto, long id)
        {
            var statment = _context.Statments.FirstOrDefault(item => item.Id == id);

            if (statment == null)
            {
                throw new Exception();
            }

            statment.Description = statmentDto.Description;
            statment.AccountId = statmentDto.AccountId;
            statment.date = statmentDto.date;

            _context.Statments.Update(statment);
            _context.SaveChanges();
        }

        public Statment GetById(long id)
        {
            return _context.Statments.FirstOrDefault(item => item.Id == id);
        }

        public List<Statment> GetByAccountId(long accountId)
        {
            return _context.Statments.Where(item => item.AccountId == accountId).ToList();
        }
    }
}
