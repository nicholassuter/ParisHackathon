using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class Quartier
    {
        public string Name { get; set; }
        public int Arrondissement { get; set; }
        public DbGeography Polygon { get; set; }
        private IEnumerable<PointOfInterest> PointsOfInterest { get; set; }
    }
}