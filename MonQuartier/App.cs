using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;

using Xamarin.Forms;

namespace MonQuartier
{
	public class App : Application
	{
		private void InitializeIoc()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			var c = SimpleIoc.Default;

			c.Register<IQuartierService, QuartierService>();
			c.Register<MainPageViewModel>();
			c.Register<CoffeeDetailViewModel>();
			c.Register<QuartierDetailViewModel>();
		}

		public App()
		{
			InitializeIoc();

			// The root page of your application
			var content = new MainPage();
			MainPage = new NavigationPage(content);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

