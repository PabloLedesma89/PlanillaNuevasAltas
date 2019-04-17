using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanillaNuevasAltas.Models;

namespace PlanillaNuevasAltas.Data
{
    public class NuevasAltasContext : DbContext
    {
        public NuevasAltasContext(DbContextOptions<NuevasAltasContext> options) : base(options)
        {
            
        }


        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<FormaPago> FormaPagos { get; set; }
        public DbSet<TipoAnalisis> TipoAnalisis { get; set; }
        public DbSet<PoliticaAnulacion> PoliticaAnulaciones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>().ToTable("Articulos").HasKey(x => x.Id);
            modelBuilder.Entity<FormaPago>().ToTable("FormasPagos").HasKey(x => x.Id);
            modelBuilder.Entity<TipoAnalisis>().ToTable("TipoAnalisis").HasKey(x => x.Id);
            modelBuilder.Entity<PoliticaAnulacion>().ToTable("PoliticaAnulaciones").HasKey(x => x.Id);
            modelBuilder.Entity<Contacto>().ToTable("Contactos").HasKey(x => x.Id);

        }

    }
}


