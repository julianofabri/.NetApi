using BankApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApi.ModelMappers
{
    public class StatmentMapper : IEntityTypeConfiguration<Statment>
    {
        public void Configure(EntityTypeBuilder<Statment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.date).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.AccountId).IsRequired();
        }
    }
}
