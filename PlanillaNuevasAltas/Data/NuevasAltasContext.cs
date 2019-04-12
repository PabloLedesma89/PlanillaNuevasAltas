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


        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Forma_pago> Forma_pago { get; set; }
        public DbSet<Tipo_Analisis> Tipo_Analisis { get; set; }
        public DbSet<Politica_Anulacion> Politica_Anulacion { get; set; }
        public DbSet<Contacto> Contacto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>().ToTable("Articulos").HasKey(x => x.Id);
            modelBuilder.Entity<FormaPago>().ToTable("FormasPagos").HasKey(x=>x.Id)
            modelBuilder.Entity<Tipo_Analisis>().ToTable("Tipo_Analisis").HasKey(x=>x.Id);
            modelBuilder.Entity<Politica_Anulacion>().ToTable("Politica_Anulacion");
            modelBuilder.Entity<Contacto>().ToTable("Contacto");

            OnModelCreating(modelBuilder);
        }

    }
}


