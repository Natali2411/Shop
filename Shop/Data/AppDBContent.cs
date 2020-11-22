using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasKey(b => b.id)
                .HasName("PrimaryKey_CarId");

            modelBuilder.Entity<Car>()
                .HasOne<Category>(s => s.Category);

            modelBuilder.Entity<Category>()
                .HasKey(b => b.id)
                .HasName("PrimaryKey_CategoryId");
        }

    }
}

