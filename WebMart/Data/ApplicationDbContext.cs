﻿using Microsoft.EntityFrameworkCore;
using WebMart.Models;

namespace WebMart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Action", DisplayOrder = 1 },
                new Category { Id = Guid.NewGuid(), Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = Guid.NewGuid(), Name = "Horror", DisplayOrder = 3 }
                );
        }
    }
}
