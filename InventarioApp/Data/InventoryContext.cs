using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventarioApp.Models;

namespace InventarioApp.Data
{
    public class InventoryContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        //Ruta de la base de datos: se guarda junto al ejecutable.
        private static string DbPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.db");

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.BarCode)
                .IsUnique();

            modelBuilder.Entity<Sale>()
                .HasOne(v => v.Product)
                .WithMany()
                .HasForeignKey(v => v.ProductId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
