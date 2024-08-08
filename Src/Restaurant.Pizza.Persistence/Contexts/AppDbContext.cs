﻿using Restaurant.Pizza.Domain.Entities.Sample;
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
    }
}
