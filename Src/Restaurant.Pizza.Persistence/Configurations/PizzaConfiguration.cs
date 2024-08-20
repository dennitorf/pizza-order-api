using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Pizza.Domain.Entities;

namespace Restaurant.Pizza.Persistence.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza.Domain.Entities.Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza.Domain.Entities.Pizza> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Price)
                .IsRequired();

            builder.Property(p => p.BeforePrice)
                .IsRequired();

            builder.HasOne(p => p.Size)
                .WithMany()
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Offer)
                .WithMany()
                .HasForeignKey(p => p.OfferId);
            
            builder.HasOne(p => p.Order)
                .WithMany(o => o.Pizzas)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring the many-to-many relationship between Pizza and Topping
            builder.HasMany(p => p.Toppings)
                .WithMany(t => t.Pizzas)
                .UsingEntity<Dictionary<string, object>>(
                    "PizzaTopping",
                    j => j.HasOne<Topping>().WithMany().HasForeignKey("ToppingId"),
                    j => j.HasOne<Pizza.Domain.Entities.Pizza>().WithMany().HasForeignKey("PizzaId")
                );

            builder.ToTable("Pizza");
        }
    }
}
