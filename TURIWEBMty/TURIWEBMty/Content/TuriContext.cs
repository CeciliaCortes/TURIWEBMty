using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TURIWEBMty.Models;

namespace TURIWEBMty.Content
{
    public class TuriContext : DbContext
    {
        public TuriContext() : base("TuriContext")
        {

        }
        public DbSet<Horario>Horarios { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<logio> login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}