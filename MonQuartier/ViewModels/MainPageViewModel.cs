using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;

namespace MonQuartier
{
	public class MainPageViewModel : ViewModelBase
	{
		IQuartierService _quartierService;

		public MainPageViewModel(IQuartierService quartierService)
		{
			_quartierService = quartierService;
		}

		private List<Quartier> _quartiers;
		private List<Quartier> _items;

		public List<Quartier> Items
		{
			get { return _items; }
			private set
			{
				_items = value;
				RaisePropertyChanged("Items");
			}
		}

		public async Task StartAsync()
		{
			var list = await _quartierService.GetQuartierListAsync();

			_quartiers = list;
			Items = list;
		}

		public void Filter(string needle)
		{
			Items = _quartiers.Where(x => x.Name.StartsWith(needle, StringComparison.Ordinal)).ToList();
		}
	}
}

