using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class Quartier
    {
        public string Nom { get; set; }
        public int Arrondissement { get; set; }

        private IEnumerable<PointOfInterest> pointsOfInterest { get; set; }
    }
}