using Restaurant.Pizza.Domain.Entities;
using Restaurant.Pizza.Domain.Entities.Sample;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Pizza.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }        
        public DbSet<Todo> Todos { set; get; }
        public DbSet<TodoItem> TodoItems { set; get; }        
        public DbSet<Size> Sizes { set; get; }
        public DbSet<ToppingType> ToppingTypes { set; get; }
        public DbSet<Topping> Toppings { set; get; }
        public DbSet<Offer> Offers { set; get; }
        public DbSet<Pizza.Domain.Entities.Pizza> Piza { set; get; }

    }
}
