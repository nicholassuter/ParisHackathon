using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Paris.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Quartier> Quartiers { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}