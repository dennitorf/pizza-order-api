using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Pizza.Domain.Entities;

namespace Restaurant.Pizza.Persistence.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(o => o.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(o => o.Discount)
                .IsRequired();

            builder.Property(o => o.PercentDiscount)
                .IsRequired();

            builder.HasOne(o => o.Size)
                .WithMany()
                .HasForeignKey(o => o.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Offer");
        }
    }
}
