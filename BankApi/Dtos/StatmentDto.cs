using BankApi.Models;

namespace BankApi.Dtos
{
    public class StatmentDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public DateTime date { get; set; }
    }
}
