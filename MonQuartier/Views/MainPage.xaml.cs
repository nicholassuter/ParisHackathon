using System;
using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Concurrency;

namespace MonQuartier
{
	public partial class MainPage : ContentPage
	{
		private IDisposable _disposableToken;

		public MainPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var vm = ServiceLocator.Current.GetInstance<MainPageViewModel>();
			BindingContext = vm;

			await vm.StartAsync();

			_disposableToken = Observable.FromEventPattern<EventHandler<TextChangedEventArgs>, TextChangedEventArgs>(
				h => quartierEntry.TextChanged += h,
				h => quartierEntry.TextChanged -= h)
				.Throttle(TimeSpan.FromMilliseconds(500))
				.Select(x => x.EventArgs.NewTextValue)
				.ObserveOn(Scheduler.CurrentThread)
				.Subscribe(x => vm.Filter(x));
		}

		private async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var quartier = e.SelectedItem as Quartier;
			if (quartier != null)
				await Navigation.PushAsync(new QuartierDetailPage(quartier));
		}

		protected override void OnDisappearing()
		{
			_disposableToken?.Dispose();
			_disposableToken = null;
			base.OnDisappearing();
		}
	}
}

