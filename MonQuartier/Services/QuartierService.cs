using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MonQuartier
{
	public interface IQuartierService
	{
		Task<List<Quartier>> GetQuartierListAsync();
		Task<List<PointOfInterest>> GetPOIListAsync(int id);
	}

	public class QuartierService : IQuartierService
	{
		public QuartierService()
		{
		}

		public async Task<List<PointOfInterest>> GetPOIListAsync(int id)
		{
			List<PointOfInterest> list;

			using (var client = new HttpClient())
			{
				var jsonString = await client.GetStringAsync("http://paris20160517043250.azurewebsites.net/api/PointOfInterest/GetPointOfInterests?QuartierId=" + id);
				list = JsonConvert.DeserializeObject<List<PointOfInterest>>(jsonString);
			}

			return list;
		}

	
		public async Task<List<Quartier>> GetQuartierListAsync()
		{
			List<Quartier> list;

			using (var client = new HttpClient())
			{
				//	private string[] _quartiers = new[] { "Barbès", "Passy", "Commerce", "Italie", "Chinatown" };
				//await Task.Delay(1000);
				//var list = new List<Quartier>();

				//for (int i = 0; i < 200; i++)
				//{
				//	var q = new Quartier();
				//	q.Arrondissement = (i % 20) + 1;
				//	q.Name = _quartiers[i % _quartiers.Length];
				//	q.PointsOfInterest = new List<PointOfInterest>(new[] { new PointOfInterest { Name = "Test POI" } });
				//	list.Add(q);
				//}

				var jsonString = await client.GetStringAsync("http://paris20160517043250.azurewebsites.net/api/quartiers");
				list = JsonConvert.DeserializeObject<List<Quartier>>(jsonString);
			}

			return list;
		}
	}
}

