using System.ComponentModel.DataAnnotations;

namespace BankApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

    }
}
