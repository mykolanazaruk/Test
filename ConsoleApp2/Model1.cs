namespace ConsoleApp2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Відгуки_про_пиво> Відгуки_про_пиво { get; set; }
        public virtual DbSet<Пиво> Пиво { get; set; }
        public virtual DbSet<Пивовар> Пивовар { get; set; }
        public virtual DbSet<Покупці_пива> Покупці_пива { get; set; }
        public virtual DbSet<Список_замовлень> Список_замовлень { get; set; }
        public virtual DbSet<Типи_пива> Типи_пива { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Відгуки_про_пиво>()
                .Property(e => e.Пиво)
                .IsFixedLength()
                .IsUnicode(true);

            modelBuilder.Entity<Відгуки_про_пиво>()
                .Property(e => e.Відгук)
                .IsUnicode(true);

            modelBuilder.Entity<Відгуки_про_пиво>()
                .Property(e => e.Покупець)
                .IsUnicode(true);

            modelBuilder.Entity<Пиво>()
                .Property(e => e.Тип_пива)
                .IsFixedLength()
                .IsUnicode(true);

            modelBuilder.Entity<Пиво>()
                .HasOptional(e => e.Пивовар)
                .WithRequired(e => e.Пиво1);

            modelBuilder.Entity<Пивовар>()
                .Property(e => e.Псевдонім)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Пивовар>()
                .Property(e => e.Пиво)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Пивовар>()
                .HasOptional(e => e.Список_замовлень)
                .WithRequired(e => e.Пивовар);

            modelBuilder.Entity<Покупці_пива>()
                .Property(e => e.Назва_компанії)
                .IsUnicode(false);

            modelBuilder.Entity<Покупці_пива>()
                .Property(e => e.Місто)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Покупці_пива>()
                .Property(e => e.Контактні_дані)
                .IsUnicode(false);

            modelBuilder.Entity<Покупці_пива>()
                .HasOptional(e => e.Список_замовлень)
                .WithRequired(e => e.Покупці_пива);

            modelBuilder.Entity<Список_замовлень>()
                .Property(e => e.Пиво)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Список_замовлень>()
                .Property(e => e.Покупець)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Список_замовлень>()
                .HasOptional(e => e.Відгуки_про_пиво)
                .WithRequired(e => e.Список_замовлень);

            modelBuilder.Entity<Список_замовлень>()
                .HasOptional(e => e.Відгуки_про_пиво1)
                .WithRequired(e => e.Список_замовлень1);

            modelBuilder.Entity<Типи_пива>()
                .Property(e => e.Назва)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Типи_пива>()
                .Property(e => e.Характеристика)
                .IsUnicode(true);

            modelBuilder.Entity<Типи_пива>()
                .HasOptional(e => e.Пиво)
                .WithRequired(e => e.Типи_пива);
        }
    }
}
