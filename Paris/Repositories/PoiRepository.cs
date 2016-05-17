using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Paris.Models;

namespace Paris.Repositories
{
    public class PoiRepository
    {
        public IEnumerable<PointOfInterest> GetPointOfInterestsByQuartierId(int quartierId)
        {
            IEnumerable<PointOfInterest> pois;
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                pois = dbContext.PointsOfInterest.Where(p => p.IdQuartier == quartierId).Include("Type").ToList();
            }

            return pois;
        }
    }
}