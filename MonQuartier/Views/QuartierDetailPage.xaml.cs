using System;
using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;

using Xamarin.Forms;

namespace MonQuartier
{
	public partial class QuartierDetailPage : ContentPage
	{
		Quartier quartier;

		public QuartierDetailPage()
		{
			InitializeComponent();
		}

		public QuartierDetailPage(Quartier quartier)
		{
			this.quartier = quartier;

			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var vm = ServiceLocator.Current.GetInstance<QuartierDetailViewModel>();
			BindingContext = vm;

			vm.Start(quartier);
		}

		private async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CoffeeDetailPage(quartier.IdQuartier, 1));
		}

		private async void Handle_Clicked2(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CoffeeDetailPage(quartier.IdQuartier, 2));
		}
	}
}
