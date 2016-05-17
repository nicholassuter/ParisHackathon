using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Paris.Models;

namespace Paris.Repositories
{
    public class QuartierRepository
    {
        public IEnumerable<Quartier> GetQuartiers()
        {
            IEnumerable<Quartier> quartiers;
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                quartiers = dbContext.Quartiers.ToList();
            }

            return quartiers;
        }
    }
}