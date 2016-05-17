using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Paris.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // attempt override standard name of complex property
            modelBuilder.Entity<Quartier>().ToTable("Quartier").HasKey(k => k.IdQuartier);
            modelBuilder.Entity<PointOfInterest>().ToTable("POI").HasKey(k => k.IdPOI);

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Quartier> Quartiers { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}