using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class Quartier
    {
        public int IdQuartier { get; set; }
        public string Name { get; set; }
        public int Arrondissement { get; set; }
        private IEnumerable<PointOfInterest> PointsOfInterest { get; set; }
    }
}