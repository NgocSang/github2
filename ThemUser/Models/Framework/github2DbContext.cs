namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class github2DbContext : DbContext
    {
        public github2DbContext()
            : base("name=github2DbContext")
        {
        }

        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<report> reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account>()
                .Property(e => e.username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<account>()
                .Property(e => e.password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<report>()
                .Property(e => e.mastercard)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<report>()
                .Property(e => e.debitcard)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
