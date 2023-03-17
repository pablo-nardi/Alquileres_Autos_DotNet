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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().ToTable("Auto");
        }
        //public DbSet<AlquileresAutos.Models.Auto> Auto { get; set; } = default!;
    }
}
