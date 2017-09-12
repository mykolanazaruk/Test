namespace Craft
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<Beer> Beers { get; set; }
        public virtual DbSet<BeerType> BeerTypes { get; set; }
        public virtual DbSet<Brewer> Brewers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<List_Of_Order> List_Of_Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>()
                .Property(e => e.BeerType)
                .IsFixedLength();

            modelBuilder.Entity<BeerType>()
                .Property(e => e.NameBeer)
                .IsFixedLength();

            modelBuilder.Entity<BeerType>()
                .Property(e => e.Characteristic)
                .IsUnicode(false);

            modelBuilder.Entity<BeerType>()
                .HasMany(e => e.Beers)
                .WithRequired(e => e.BeerType1)
                .HasForeignKey(e => e.BeerType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BeerType>()
                .HasMany(e => e.Brewers)
                .WithRequired(e => e.BeerType)
                .HasForeignKey(e => e.Beer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BeerType>()
                .HasMany(e => e.FeedBacks)
                .WithRequired(e => e.BeerType)
                .HasForeignKey(e => e.Beer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BeerType>()
                .HasMany(e => e.List_Of_Orders)
                .WithRequired(e => e.BeerType)
                .HasForeignKey(e => e.Beer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brewer>()
                .Property(e => e.NikNMame)
                .IsFixedLength();

            modelBuilder.Entity<Brewer>()
                .Property(e => e.Beer)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Company_Name)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone_Number)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.FeedBacks)
                .WithRequired(e => e.Customer1)
                .HasForeignKey(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.List_Of_Orders)
                .WithRequired(e => e.Customer1)
                .HasForeignKey(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.Beer)
                .IsFixedLength();

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.Feedback1)
                .IsUnicode(false);

            modelBuilder.Entity<FeedBack>()
                .Property(e => e.Customer)
                .IsFixedLength();

            modelBuilder.Entity<List_Of_Order>()
                .Property(e => e.Beer)
                .IsFixedLength();

            modelBuilder.Entity<List_Of_Order>()
                .Property(e => e.Customer)
                .IsFixedLength();

            modelBuilder.Entity<List_Of_Order>()
                .Property(e => e.Valuta)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
