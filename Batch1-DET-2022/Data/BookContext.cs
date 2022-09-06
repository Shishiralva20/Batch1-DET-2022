using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
        {

        }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
       public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=6BBYQG2-SHEL;Database=Training;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Property Configurations

            //fluent API

            modelBuilder.Entity<Book>()
                .Property(b => b.price)
                .IsRequired() //[Required]
                .HasColumnName("BKprice") //[Column("bkprice)]
                .HasDefaultValue(200);
        }
    }
}
