namespace BankApi.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Agency { get; set; }
        public double Balance { get;set; }
    }
}