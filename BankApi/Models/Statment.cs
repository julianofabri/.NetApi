using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{
    public class Statment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
