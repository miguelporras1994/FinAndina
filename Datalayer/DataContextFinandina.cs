using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Datalayer
{
    public partial class DataContextFinandina : DbContext
    {
        public DataContextFinandina()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<TipoTransacciones> TipoTransacciones { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cuidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cuenta)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.Id_Cliente);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.Transacciones)
                .WithOptional(e => e.Cuenta)
                .HasForeignKey(e => e.Id_Destino);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.Transacciones1)
                .WithOptional(e => e.Cuenta1)
                .HasForeignKey(e => e.Id_Origen);

            modelBuilder.Entity<TipoTransacciones>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTransacciones>()
                .HasMany(e => e.Transacciones)
                .WithOptional(e => e.TipoTransacciones)
                .HasForeignKey(e => e.Tipo_Transacciones);
        }
    }
}
