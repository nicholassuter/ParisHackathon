using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class PointOfInterest
    {
        public string Name { get; set; }
        public PoIType PoIType { get; set; }
        public DbGeography Coordinates { get; set; }

    }

    public class PoIType
    {
        public string Name { get; set; }
    }
}