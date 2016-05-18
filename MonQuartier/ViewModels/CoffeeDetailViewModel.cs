using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Linq;

namespace MonQuartier
{
	public class CoffeeDetailViewModel : ViewModelBase
	{
		IQuartierService _quartierService;

		public CoffeeDetailViewModel(IQuartierService quartierService)
		{
			_quartierService = quartierService;
		}

		public async Task StartAsync(int id, int type)
		{
			var list = await _quartierService.GetPOIListAsync(id);
			list = list.Where(x => x.Type.TypeId == type).ToList();
			Items = list;
		}

		private List<PointOfInterest> _items;
		public List<PointOfInterest> Items { 
			get { return _items; }
			private set
			{
				_items = value;
				RaisePropertyChanged(() => Items);
			}
		}
	}
}

