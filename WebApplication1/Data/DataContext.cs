using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using System.Diagnostics.Metrics;
using ECommerce.Models;

namespace Ecommerce.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Paymentdetails> Paymentdetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresss { get; set; }    
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().HasKey(o => new { o.CustomerID , o.PaymentdetailsID , o.AddressID }); 
            modelBuilder.Entity<Orders>()
                .HasOne(c => c.Customer) 
                .WithMany(o => o.Orders)
                .HasForeignKey(c => c.CustomerID);
            modelBuilder.Entity<Orders>()
               .HasOne(a => a.Address)
               .WithMany(o => o.Orders)
               .HasForeignKey(a => a.AddressID);
            modelBuilder.Entity<Orders>()
                .HasOne(pm => pm.Paymentdetails)
                .WithMany (o => o.Orders)
                .HasForeignKey(pm => pm.PaymentdetailsID);

            modelBuilder.Entity<Address>().HasKey(a => new { a.CustomerID });
            modelBuilder.Entity<Address>()
                .HasOne(c => c.Customer)
                .WithMany(a => a.Address)
                .HasForeignKey(c => c.CustomerID);

            modelBuilder.Entity<Paymentdetails>().HasKey(pm => new { pm.CustomerID });
            modelBuilder.Entity<Paymentdetails>()
                .HasOne(c=> c.Customer)
                .WithMany(pm => pm.Paymentdetails)
                .HasForeignKey(c => c.CustomerID);

        }
    }
}