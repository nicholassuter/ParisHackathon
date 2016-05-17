using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class Quartier
    {
        [Key]
        public int IdQuartier { get; set; }
        public string Name { get; set; }
        public int Arrondissement { get; set; }
        public DbGeography Polygon { get; set; }
        private IEnumerable<PointOfInterest> PointsOfInterest { get; set; }
    }
}