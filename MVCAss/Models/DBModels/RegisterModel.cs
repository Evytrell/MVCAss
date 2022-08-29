using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCAss.Models.DBModels
{
    public partial class RegisterModel : DbContext
    {
        public RegisterModel()
            : base("name=RegisterModel")
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Merchant> Merchants { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Merchant>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Merchant>()
                .HasOptional(e => e.Merchants1)
                .WithRequired(e => e.Merchant1);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);
        }
    }
}
