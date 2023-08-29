using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCO.Models;

namespace UCO.Data
{
    public class ContextDbUCO :   DbContext
    {
        public ContextDbUCO(DbContextOptions<ContextDbUCO> opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              
             "Data Source=.;Initial Catalog=UCODB;Integrated Security=true"
             );
            base.OnConfiguring(optionsBuilder);
            //Primer Migracion   Add-Migration InitialCreate
            //Despues de la primera migracion se utiliza  Update-Database
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ArtietaCancionView>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("ArtietaCancionView");
                       
                    });
        }
        public DbSet<ArtietaCancionView> ArtietaCancionView { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cancion> Cancions { get; set; }
    }
}
