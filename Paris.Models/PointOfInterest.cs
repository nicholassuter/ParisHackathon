using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Spatial;

namespace Paris.Models
{
    public class PointOfInterest
    {
        public int IdPOI { get; set; }
        public int IdQuartier { get; set; }
        public string Name { get; set; }
        public DbGeometry Point { get; set; }
        //public int TypeId { get; set; }
        public Type Type { get; set; }
        public int TypeId { get; set; }
    }

    public class Type
    {
        public int TypeId { get; set; }
        public string Label { get; set; }
    }
}