using SchoolFunderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolFunderAPI.DataAccessLayer
{
    public class SchoolFunderContext : DbContext
    {
        public SchoolFunderContext(DbContextOptions options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes{ get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<School>().ToTable("Schools");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Payment>().ToTable("Payments");
            modelBuilder.Entity<PaymentType>().ToTable("PaymentTypes");
            modelBuilder.Entity<Category>().ToTable("Categories");

        }

    }
}
