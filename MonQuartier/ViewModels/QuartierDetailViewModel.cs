using System;
using GalaSoft.MvvmLight;

namespace MonQuartier
{
	public class QuartierDetailViewModel : ViewModelBase
	{
		public QuartierDetailViewModel()
		{
		}

		public void Start(Quartier quartier)
		{
			Quartier = quartier;
			RaisePropertyChanged(() => Quartier);
		}

		public Quartier Quartier { get; private set; }
	}
}

