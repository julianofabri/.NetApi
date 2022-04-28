namespace BankApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<BankAccount> BankAccount { get; set; }

    }
}
