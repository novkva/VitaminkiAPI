using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class IngredientContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }

        public IngredientContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Vitamins.db");
        }
    }
}
