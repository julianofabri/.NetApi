using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Statment> statments { get; set; }
    }
}
