using Restaurant.Pizza.Persistence.Contexts;

namespace Restaurant.Pizza.Persistence.Seeders
{
    public class AppDbContextSeeder
    {        

        public void SeedEverything(AppDbContext db)
        { 
            db.Database.EnsureCreated();    
        }

        // Add your own seed methods 

    }
}
