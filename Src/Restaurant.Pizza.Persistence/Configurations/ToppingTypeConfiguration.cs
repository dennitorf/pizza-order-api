using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Pizza.Domain.Entities;

namespace Restaurant.Pizza.Persistence.Configurations
{
    public class ToppingTypeConfiguration : IEntityTypeConfiguration<ToppingType>
    {
        public void Configure(EntityTypeBuilder<ToppingType> builder)
        {
            builder.HasKey(tt => tt.Id);

            builder.Property(tt => tt.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(tt => tt.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.ToTable("ToppingType");
        }
    }
}
