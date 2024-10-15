using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecom_app.Models;
using Microsoft.EntityFrameworkCore;
using ShopEase_app.Models;

namespace ecom_app.Data
{
    public class ecom_appContext : DbContext
    {
        public ecom_appContext (DbContextOptions<ecom_appContext> options)
            : base(options)
        {
        }

        public DbSet<ShopEase_app.Models.Category> Category { get; set; }

        public DbSet<ShopEase_app.Models.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                        .HasOne(c => c.Category)
                        .WithMany(p => p.Products)
                        .HasForeignKey(c => c.CategoryId)
                        .OnDelete(DeleteBehavior.Cascade);


         


            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade); // cart is deleted -->items 

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict); 


            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
        }
    }
}
