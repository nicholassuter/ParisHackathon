using System;
using System.Collections.Generic;

namespace MonQuartier
{
	public class PointOfInterest
	{
		public int IdPOI { get; set; }
		public string IdQuartier { get; set; }
		public string Name { get; set; }
		public POIType Type { get; set; }
	}

	public class POIType
	{
		public string Label { get; set; }
		public int TypeId { get; set; }
	}

	public class Quartier
	{
		public int IdQuartier { get; set; }
		public string Name { get; set; }
		public int Arrondissement { get; set; }
	}
}

