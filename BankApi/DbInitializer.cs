using BankApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApi
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<User>().HasData(
                   new User() { Id = 1, Name = "Juliano" },
                   new User() { Id = 2, Name = "Otavio" },
                   new User() { Id = 3, Name = "Henrique" },
                   new User() { Id = 4, Name = "Maria Gabriela" }
            );
        }
    }
}
