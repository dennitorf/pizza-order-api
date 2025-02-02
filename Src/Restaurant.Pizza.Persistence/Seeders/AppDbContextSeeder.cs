﻿using System.Collections.Generic;
using System.Linq;
using Restaurant.Pizza.Domain.Entities;
using Restaurant.Pizza.Persistence.Contexts;

namespace Restaurant.Pizza.Persistence.Seeders
{
    public class AppDbContextSeeder
    {        

        public void SeedEverything(AppDbContext db)
        { 
            db.Database.EnsureCreated(); 

            SeedToppingTypes(db);

            SeedToppings(db);

            SeedSizes(db);   

            db.SaveChanges();             
        }

        private void SeedToppingTypes(AppDbContext db)
        {
            var toppingTypes = new List<ToppingType>
            {
                new ToppingType { Code = "veg", Description = "Vegetarian" },
                new ToppingType { Code = "non-veg", Description = "Non-Vegetarian" }
            };

            foreach (var toppingType in toppingTypes)
            {
                // Add the topping type if it doesn't already exist
                if (!db.ToppingTypes.Any(tt => tt.Code == toppingType.Code))
                {
                    db.ToppingTypes.Add(toppingType);
                }
            }
            db.SaveChanges();
        }

       private void SeedSizes(AppDbContext db)
        {
            var sizes = new List<Size>
            {
                new() { Code = "small", Description = "Small", Price = 5 },
                new() { Code = "medium", Description = "Medium", Price = 7 },
                new() { Code = "large", Description = "Large", Price = 8 },
                new() { Code = "extra-large", Description = "Extra Large", Price = 9 }
            };

            foreach (var size in sizes)
            {
                // Add the size if it doesn't already exist
                if (!db.Sizes.Any(s => s.Code == size.Code))
                {
                    db.Sizes.Add(size);
                }
            }
        }

        private void SeedToppings(AppDbContext db)
        {
            var toppings = new List<Topping>
            {
                new() { Code = "tom", Description = "Tomates", Price = 1, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "veg").Id },
                new() { Code = "oni", Description = "Onions", Price = 0.5M, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "veg").Id },
                new() { Code = "bpe", Description = "Bell pepper", Price = 1, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "veg").Id },
                new() { Code = "msh", Description = "Mushrooms", Price = 1.2M, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "veg").Id },
                new() { Code = "pin", Description = "Pineapple", Price = 0.75M, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "veg").Id },
                new() { Code = "sau", Description = "Sausage", Price = 1, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "non-veg").Id },
                new() { Code = "pep", Description = "Pepperoni", Price = 2, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "non-veg").Id },
                new() { Code = "bbq", Description = "Barbecue chicken", Price = 3, ToppingTypeId = db.ToppingTypes.FirstOrDefault(tt => tt.Code == "non-veg").Id }
            };

            foreach (var topping in toppings)
            {
                // Add the topping if it doesn't already exist
                if (!db.Toppings.Any(t => t.Code == topping.Code))
                {
                    db.Toppings.Add(topping);
                }
            }
        }

    }
}
