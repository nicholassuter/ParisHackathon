using System;
using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms.Maps;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace MonQuartier
{
	public partial class CoffeeDetailPage : ContentPage
	{
		private int _quartier;
		int _type;
		private CoffeeDetailViewModel vm;

		public CoffeeDetailPage()
		{
			InitializeComponent();
		}

		public CoffeeDetailPage(int quartier, int type)
		{
			_quartier = quartier;
			_type = type;

			Title = type == 1 ? "Café à une euros" : "Vélib";
			InitializeComponent();

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			vm = ServiceLocator.Current.GetInstance<CoffeeDetailViewModel>();
			BindingContext = vm;

			await vm.StartAsync(_quartier, _type);

	//		MyMap.MoveToRegion(
	//MapSpan.FromCenterAndRadius(
	//				new Position(37, -122), Distance.FromMiles(1)));
		}
	}
}

