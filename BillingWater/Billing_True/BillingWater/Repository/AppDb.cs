using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Business
{
    public partial class AppDb : DbContext
    {
        public AppDb()
            : base("name=AppDb1")
        {
        }

        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billing>()
                .Property(e => e.ReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Bill)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.DueDate)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountUserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountEmail)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.AccountType)
                .IsFixedLength();
        }
    }
}
