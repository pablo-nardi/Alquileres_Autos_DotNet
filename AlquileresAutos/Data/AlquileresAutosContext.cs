using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Models;

namespace AlquileresAutos.Data
{
    public class AlquileresAutosContext : DbContext
    {
        public AlquileresAutosContext (DbContextOptions<AlquileresAutosContext> options)
            : base(options)
        {
        }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoAuto> TipoAutos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().ToTable("Auto");
            modelBuilder.Entity<Modelo>().ToTable("Modelo");
            modelBuilder.Entity<TipoAuto>().ToTable("TipoAuto");
            modelBuilder.Entity<Auto>()
                .HasIndex(e => e.Patente)
                .IsUnique();
        }
        public DbSet<AlquileresAutos.Models.Localidad> Localidad { get; set; }
        public DbSet<AlquileresAutos.Models.Provincia> Provincia { get; set; }

    }
}
