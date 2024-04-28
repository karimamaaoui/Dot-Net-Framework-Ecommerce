﻿using Microsoft.EntityFrameworkCore;

namespace projetDotNet.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }



    }
}
