using NodaTime;
using System;
using Microsoft.EntityFrameworkCore;

namespace ApiGraphQL.Data
{
    public class AdmContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost; post=5432; userid=postgres; pwd=password; database=apigraphql", npgOptionsBuilder =>
            {
                npgOptionsBuilder.UseNodaTime();
            });
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductCategory>()
                .HasKey(t => new { t.ProductId, t.CategoryId });

            modelBuilder.Entity<StockProduct>()
                .HasKey(t => new { t.StockId, t.ProductId });
            
            modelBuilder.Entity<StockWine>()
                .HasKey(t => new { t.StockId, t.WineId });
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Wine> Wines { get; set; }
    }
}