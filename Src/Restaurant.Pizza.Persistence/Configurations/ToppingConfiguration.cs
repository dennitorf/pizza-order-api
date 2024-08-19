using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Pizza.Domain.Entities;

namespace Restaurant.Pizza.Persistence.Configurations
{
    public class ToppingConfiguration : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Price)
                .IsRequired();

            builder.HasOne(t => t.ToppingType)
                .WithMany()
                .HasForeignKey(t => t.ToppingTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Topping");
        }
    }
}
