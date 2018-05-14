using SchoolFunderAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFunderAPI.DataAccessLayer
{
    public class SchoolFunderContext : DbContext
    {
        public SchoolFunderContext() : base("SchoolFunderContext") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes{ get; set; }
        public DbSet<Category> Categories{ get; set; }

    }
}
