using BankApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApi.ModelMappers
{
    public class AccountMapper : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Amount).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
        }
    }
}
